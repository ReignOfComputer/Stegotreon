using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stegotreon
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        Bitmap MainImage;
        Bitmap EncryptedImage;
        string[] type = new string[3];
        private bool StegoTypeGUIDorPlaintext = true;
        private bool OutputTypeFoldersorFiles = true;
        private int NamingType = 0; // 0 = Original, 1 = Name, 2 = GUID
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Embed_Click(object sender, EventArgs e)
        {
            var StegoList = File.ReadAllLines(@TextBox_StegoListDir.Text);
            int TotalNumber = StegoList.Count();
            int Completed = 0;

            if (StegoTypeGUIDorPlaintext)
            {
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@TextBox_DirectoryDir.Text + "GUIDLookup.txt", true))
                {
                    file.WriteLine("User:GUID");
                }
            }
            
            foreach (string stego in StegoList)
            {
                MainImage = new Bitmap(@TextBox_ImageFileDir.Text);
                string CurrentName = stego;
                char[] CurrentNameArray = CurrentName.ToArray();
                string EncryptText = "";
                string CurrentGUID = "";

                if (StegoTypeGUIDorPlaintext)
                {
                    CurrentGUID = Guid.NewGuid().ToString();
                    EncryptText = CurrentGUID;
                    CurrentNameArray = CurrentGUID.ToArray();
                }
                else
                {
                    EncryptText = CurrentName;
                }

                #region IMG-Stego Logic
                string[] type = new string[] { "t", "t", "1" };

                for (int j = 0; j < 3; j++)
                {
                    Color pixel = MainImage.GetPixel(MainImage.Width - j - 1, MainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(type[j]));
                    MainImage.SetPixel(MainImage.Width - j - 1, MainImage.Height - 1, pixel);
                }

                string a = Convert.ToString(EncryptText.Length);
                a = a.PadLeft(13, '0');
                char[] b = a.ToArray();

                for (int j = 3; j < 16; j++)
                {
                    string aString = Convert.ToString(b[j - 3]);
                    Color pixel = MainImage.GetPixel(MainImage.Width - j - 1, MainImage.Height - 1);
                    pixel = embed(pixel, getStringBits(aString));
                    MainImage.SetPixel(MainImage.Width - j - 1, MainImage.Height - 1, pixel);
                }

                int k = 0;

                for (int i = 0; i < MainImage.Height; i++)
                {
                    for (int j = 0; j < MainImage.Width; j++)
                    {
                        if (k < EncryptText.Length)
                        {
                            string msg = Convert.ToString(CurrentNameArray[i + j]);
                            Color pixel = MainImage.GetPixel(j, i);
                            pixel = embed(pixel, getStringBits(msg));
                            MainImage.SetPixel(j, i, pixel);
                            k++;
                        }
                    }
                }
                #endregion

                string SavePath = "";

                if (OutputTypeFoldersorFiles)
                {
                    Directory.CreateDirectory(TextBox_DirectoryDir.Text + CurrentName);
                    SavePath = TextBox_DirectoryDir.Text + CurrentName + "\\";
                }
                else
                {
                    SavePath = TextBox_DirectoryDir.Text;
                }

                string HoldPath = TextBox_ImageFileDir.Text.Substring(TextBox_ImageFileDir.Text.LastIndexOf("\\"));

                if (NamingType == 0)
                    SavePath += HoldPath;
                else if (NamingType == 1)
                    SavePath += HoldPath.Substring(0, HoldPath.Length - 4) + "_" + CurrentName + ".png";
                else
                    SavePath += HoldPath.Substring(0, HoldPath.Length - 4) + "_" + EncryptText.Substring(0, 8) + ".png";

                try
                {
                    MainImage.Save(SavePath);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error while writing file!" + ioe.Message);
                }

                if (StegoTypeGUIDorPlaintext)
                {
                    using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@TextBox_DirectoryDir.Text + "GUIDLookup.txt", true))
                    {
                        file.WriteLine(CurrentName + ":" + CurrentGUID);
                    }
                }

                Completed++;
                EmbedProgressBar.Value = (Completed / TotalNumber * 100);
            }

            MessageBox.Show("Complete: Generated " + TotalNumber + " files.");
        }

        private void Button_ImageFile_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox_ImageFileDir.Text = ofd.FileName;
                TextBox_DirectoryDir.Text = ofd.FileName.Substring(0, ofd.FileName.LastIndexOf("\\") + 1);
            }
        }

        private void Button_StegoList_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text File (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox_StegoListDir.Text = ofd.FileName;
            }
        }

        private void Button_Directory_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBox_DirectoryDir.Text = fbd.SelectedPath + "\\";
            }
        }

        private void Button_ImageFileExtract_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox_ImageFileExtractDir.Text = ofd.FileName;
            }
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            EncryptedImage = new Bitmap(TextBox_ImageFileExtractDir.Text);
            string HoldText = "";

            for (int j = 0; j < 3; j++)
            {
                Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                byte detype = extract(pixelToDecode);
                type[j] = Encoding.ASCII.GetString(BitConverter.GetBytes(detype));
                HoldText += type[j];
            }
            char[] typex = (HoldText).ToCharArray();

            if (typex[0] == 't' && typex[2] == 't' && typex[4] == '1')
            {
                int k = 0;
                string tlength = "";

                for (int j = 3; j < 16; j++)
                {
                    Color pixelToDecode = EncryptedImage.GetPixel(EncryptedImage.Width - j - 1, EncryptedImage.Height - 1);
                    byte delength = extract(pixelToDecode);
                    tlength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(delength)));
                }

                int length = Convert.ToInt32(tlength);

                k = 0;

                TextBox_Result.Text = "";

                for (int i = 0; i < EncryptedImage.Height; i++)
                {
                    for (int j = 0; j < EncryptedImage.Width; j++)
                    {
                        if (k < length)
                        {
                            Color pixelToDecode = EncryptedImage.GetPixel(j, i);
                            byte demsg = extract(pixelToDecode);
                            TextBox_Result.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(demsg));
                            k++;
                        }
                    }
                }
            }
            else
            {
                TextBox_Result.Text = "NO STEGO DETECTED";
            }
        }

        #region Radio Buttons
        private void RadioButton_GUID_CheckedChanged(object sender, EventArgs e)
        {
            StegoTypeGUIDorPlaintext = true;
            RadioButton_AppendGUID.Enabled = true;
        }

        private void RadioButton_Plaintext_CheckedChanged(object sender, EventArgs e)
        {
            StegoTypeGUIDorPlaintext = false;
            RadioButton_AppendGUID.Enabled = false;
            if (NamingType == 2)
            {
                NamingType = 0;
                RadioButton_Original.Checked = true;
            }
        }

        private void RadioButton_Folders_CheckedChanged(object sender, EventArgs e)
        {
            OutputTypeFoldersorFiles = true;
            RadioButton_Original.Enabled = true;
        }

        private void RadioButton_Files_CheckedChanged(object sender, EventArgs e)
        {
            OutputTypeFoldersorFiles = false;
            if (NamingType == 0)
            {
                RadioButton_AppendName.Checked = true;
                NamingType = 1;
            }
            RadioButton_Original.Enabled = false;
        }

        private void RadioButton_Original_CheckedChanged(object sender, EventArgs e)
        {
            NamingType = 0;
        }

        private void RadioButton_AppendName_CheckedChanged(object sender, EventArgs e)
        {
            NamingType = 1;
        }

        private void RadioButton_AppendGUID_CheckedChanged(object sender, EventArgs e)
        {
            NamingType = 2;
        }
        #endregion

        #region IMG-Stego Logic
        public Color embed(Color pixel, byte[] bits)
        {
            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);

            RedBits[5] = bits[0];
            GreenBits[5] = bits[1];
            RedBits[6] = bits[2];
            RedBits[7] = bits[3];
            GreenBits[6] = bits[4];
            GreenBits[7] = bits[5];
            BlueBits[6] = bits[6];
            BlueBits[7] = bits[7];

            byte newRed = getByte(RedBits);
            byte newGreen = getByte(GreenBits);
            byte newBlue = getByte(BlueBits);

            return Color.FromArgb(newRed, newGreen, newBlue);
        }

        public byte extract(Color pixel)
        {
            byte[] RedBits = getBits((byte)pixel.R);
            byte[] GreenBits = getBits((byte)pixel.G);
            byte[] BlueBits = getBits((byte)pixel.B);
            byte[] BitsToDecrypt = new byte[8];

            BitsToDecrypt[0] = RedBits[5];
            BitsToDecrypt[1] = GreenBits[5];
            BitsToDecrypt[2] = RedBits[6];
            BitsToDecrypt[3] = RedBits[7];
            BitsToDecrypt[4] = GreenBits[6];
            BitsToDecrypt[5] = GreenBits[7];
            BitsToDecrypt[6] = BlueBits[6];
            BitsToDecrypt[7] = BlueBits[7];

            return getByte(BitsToDecrypt);
        }

        private byte getByte(byte[] bits)
        {
            String bitString = "";
            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newpix = Convert.ToByte(bitString, 2);
            int dePix = (int)newpix;
            return (byte)dePix;
        }

        private byte[] getStringBits(string data)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
            BitArray bits = new BitArray(text);
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        private byte[] getBits(byte simplepixel)
        {
            int pixel = 0;
            pixel = (int)simplepixel;
            BitArray bits = new BitArray(new byte[] { (byte)pixel });
            bool[] boolarray = new bool[bits.Count];
            bits.CopyTo(boolarray, 0);
            byte[] bitsArray = boolarray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }
        #endregion
    }
}
