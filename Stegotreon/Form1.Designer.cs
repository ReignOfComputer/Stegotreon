namespace Stegotreon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Embed = new System.Windows.Forms.TabPage();
            this.EmbedProgressBar = new System.Windows.Forms.ProgressBar();
            this.GroupBox_StegoType = new System.Windows.Forms.GroupBox();
            this.RadioButton_GUID = new System.Windows.Forms.RadioButton();
            this.RadioButton_Plaintext = new System.Windows.Forms.RadioButton();
            this.GroupBox_Naming = new System.Windows.Forms.GroupBox();
            this.RadioButton_AppendName = new System.Windows.Forms.RadioButton();
            this.RadioButton_Original = new System.Windows.Forms.RadioButton();
            this.RadioButton_AppendGUID = new System.Windows.Forms.RadioButton();
            this.GroupBox_OutputType = new System.Windows.Forms.GroupBox();
            this.RadioButton_Folders = new System.Windows.Forms.RadioButton();
            this.RadioButton_Files = new System.Windows.Forms.RadioButton();
            this.Button_Embed = new System.Windows.Forms.Button();
            this.Button_Directory = new System.Windows.Forms.Button();
            this.TextBox_DirectoryDir = new System.Windows.Forms.TextBox();
            this.Label_Directory = new System.Windows.Forms.Label();
            this.Button_StegoList = new System.Windows.Forms.Button();
            this.Button_ImageFile = new System.Windows.Forms.Button();
            this.TextBox_StegoListDir = new System.Windows.Forms.TextBox();
            this.TextBox_ImageFileDir = new System.Windows.Forms.TextBox();
            this.Label_StegoList = new System.Windows.Forms.Label();
            this.Label_ImageFile = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Button_Extract = new System.Windows.Forms.Button();
            this.Button_ImageFileExtract = new System.Windows.Forms.Button();
            this.TextBox_ImageFileExtractDir = new System.Windows.Forms.TextBox();
            this.Label_ImageFileExtract = new System.Windows.Forms.Label();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Embed.SuspendLayout();
            this.GroupBox_StegoType.SuspendLayout();
            this.GroupBox_Naming.SuspendLayout();
            this.GroupBox_OutputType.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Embed);
            this.TabControl_Main.Controls.Add(this.tabPage2);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(696, 723);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Embed
            // 
            this.TabPage_Embed.Controls.Add(this.EmbedProgressBar);
            this.TabPage_Embed.Controls.Add(this.GroupBox_StegoType);
            this.TabPage_Embed.Controls.Add(this.GroupBox_Naming);
            this.TabPage_Embed.Controls.Add(this.GroupBox_OutputType);
            this.TabPage_Embed.Controls.Add(this.Button_Embed);
            this.TabPage_Embed.Controls.Add(this.Button_Directory);
            this.TabPage_Embed.Controls.Add(this.TextBox_DirectoryDir);
            this.TabPage_Embed.Controls.Add(this.Label_Directory);
            this.TabPage_Embed.Controls.Add(this.Button_StegoList);
            this.TabPage_Embed.Controls.Add(this.Button_ImageFile);
            this.TabPage_Embed.Controls.Add(this.TextBox_StegoListDir);
            this.TabPage_Embed.Controls.Add(this.TextBox_ImageFileDir);
            this.TabPage_Embed.Controls.Add(this.Label_StegoList);
            this.TabPage_Embed.Controls.Add(this.Label_ImageFile);
            this.TabPage_Embed.Location = new System.Drawing.Point(8, 39);
            this.TabPage_Embed.Name = "TabPage_Embed";
            this.TabPage_Embed.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Embed.Size = new System.Drawing.Size(680, 676);
            this.TabPage_Embed.TabIndex = 0;
            this.TabPage_Embed.Text = "Embed";
            this.TabPage_Embed.UseVisualStyleBackColor = true;
            // 
            // EmbedProgressBar
            // 
            this.EmbedProgressBar.Location = new System.Drawing.Point(11, 607);
            this.EmbedProgressBar.Name = "EmbedProgressBar";
            this.EmbedProgressBar.Size = new System.Drawing.Size(653, 54);
            this.EmbedProgressBar.TabIndex = 14;
            // 
            // GroupBox_StegoType
            // 
            this.GroupBox_StegoType.Controls.Add(this.RadioButton_GUID);
            this.GroupBox_StegoType.Controls.Add(this.RadioButton_Plaintext);
            this.GroupBox_StegoType.Location = new System.Drawing.Point(14, 201);
            this.GroupBox_StegoType.Name = "GroupBox_StegoType";
            this.GroupBox_StegoType.Size = new System.Drawing.Size(653, 102);
            this.GroupBox_StegoType.TabIndex = 13;
            this.GroupBox_StegoType.TabStop = false;
            this.GroupBox_StegoType.Text = "Stego Type";
            // 
            // RadioButton_GUID
            // 
            this.RadioButton_GUID.AutoSize = true;
            this.RadioButton_GUID.Checked = true;
            this.RadioButton_GUID.Location = new System.Drawing.Point(199, 42);
            this.RadioButton_GUID.Name = "RadioButton_GUID";
            this.RadioButton_GUID.Size = new System.Drawing.Size(94, 29);
            this.RadioButton_GUID.TabIndex = 11;
            this.RadioButton_GUID.TabStop = true;
            this.RadioButton_GUID.Text = "GUID";
            this.RadioButton_GUID.UseVisualStyleBackColor = true;
            this.RadioButton_GUID.CheckedChanged += new System.EventHandler(this.RadioButton_GUID_CheckedChanged);
            // 
            // RadioButton_Plaintext
            // 
            this.RadioButton_Plaintext.AutoSize = true;
            this.RadioButton_Plaintext.Location = new System.Drawing.Point(354, 42);
            this.RadioButton_Plaintext.Name = "RadioButton_Plaintext";
            this.RadioButton_Plaintext.Size = new System.Drawing.Size(126, 29);
            this.RadioButton_Plaintext.TabIndex = 10;
            this.RadioButton_Plaintext.Text = "Plaintext";
            this.RadioButton_Plaintext.UseVisualStyleBackColor = true;
            this.RadioButton_Plaintext.CheckedChanged += new System.EventHandler(this.RadioButton_Plaintext_CheckedChanged);
            // 
            // GroupBox_Naming
            // 
            this.GroupBox_Naming.Controls.Add(this.RadioButton_AppendName);
            this.GroupBox_Naming.Controls.Add(this.RadioButton_Original);
            this.GroupBox_Naming.Controls.Add(this.RadioButton_AppendGUID);
            this.GroupBox_Naming.Location = new System.Drawing.Point(14, 417);
            this.GroupBox_Naming.Name = "GroupBox_Naming";
            this.GroupBox_Naming.Size = new System.Drawing.Size(653, 102);
            this.GroupBox_Naming.TabIndex = 13;
            this.GroupBox_Naming.TabStop = false;
            this.GroupBox_Naming.Text = "Naming";
            // 
            // RadioButton_AppendName
            // 
            this.RadioButton_AppendName.AutoSize = true;
            this.RadioButton_AppendName.Location = new System.Drawing.Point(232, 42);
            this.RadioButton_AppendName.Name = "RadioButton_AppendName";
            this.RadioButton_AppendName.Size = new System.Drawing.Size(179, 29);
            this.RadioButton_AppendName.TabIndex = 12;
            this.RadioButton_AppendName.Text = "Append Name";
            this.RadioButton_AppendName.UseVisualStyleBackColor = true;
            this.RadioButton_AppendName.CheckedChanged += new System.EventHandler(this.RadioButton_AppendName_CheckedChanged);
            // 
            // RadioButton_Original
            // 
            this.RadioButton_Original.AutoSize = true;
            this.RadioButton_Original.Checked = true;
            this.RadioButton_Original.Location = new System.Drawing.Point(76, 42);
            this.RadioButton_Original.Name = "RadioButton_Original";
            this.RadioButton_Original.Size = new System.Drawing.Size(117, 29);
            this.RadioButton_Original.TabIndex = 11;
            this.RadioButton_Original.TabStop = true;
            this.RadioButton_Original.Text = "Original";
            this.RadioButton_Original.UseVisualStyleBackColor = true;
            this.RadioButton_Original.CheckedChanged += new System.EventHandler(this.RadioButton_Original_CheckedChanged);
            // 
            // RadioButton_AppendGUID
            // 
            this.RadioButton_AppendGUID.AutoSize = true;
            this.RadioButton_AppendGUID.Location = new System.Drawing.Point(444, 42);
            this.RadioButton_AppendGUID.Name = "RadioButton_AppendGUID";
            this.RadioButton_AppendGUID.Size = new System.Drawing.Size(174, 29);
            this.RadioButton_AppendGUID.TabIndex = 10;
            this.RadioButton_AppendGUID.Text = "Append GUID";
            this.RadioButton_AppendGUID.UseVisualStyleBackColor = true;
            this.RadioButton_AppendGUID.CheckedChanged += new System.EventHandler(this.RadioButton_AppendGUID_CheckedChanged);
            // 
            // GroupBox_OutputType
            // 
            this.GroupBox_OutputType.Controls.Add(this.RadioButton_Folders);
            this.GroupBox_OutputType.Controls.Add(this.RadioButton_Files);
            this.GroupBox_OutputType.Location = new System.Drawing.Point(11, 309);
            this.GroupBox_OutputType.Name = "GroupBox_OutputType";
            this.GroupBox_OutputType.Size = new System.Drawing.Size(653, 102);
            this.GroupBox_OutputType.TabIndex = 12;
            this.GroupBox_OutputType.TabStop = false;
            this.GroupBox_OutputType.Text = "Output Type";
            // 
            // RadioButton_Folders
            // 
            this.RadioButton_Folders.AutoSize = true;
            this.RadioButton_Folders.Checked = true;
            this.RadioButton_Folders.Location = new System.Drawing.Point(79, 42);
            this.RadioButton_Folders.Name = "RadioButton_Folders";
            this.RadioButton_Folders.Size = new System.Drawing.Size(214, 29);
            this.RadioButton_Folders.TabIndex = 11;
            this.RadioButton_Folders.TabStop = true;
            this.RadioButton_Folders.Text = "Output as Folders";
            this.RadioButton_Folders.UseVisualStyleBackColor = true;
            this.RadioButton_Folders.CheckedChanged += new System.EventHandler(this.RadioButton_Folders_CheckedChanged);
            // 
            // RadioButton_Files
            // 
            this.RadioButton_Files.AutoSize = true;
            this.RadioButton_Files.Location = new System.Drawing.Point(360, 42);
            this.RadioButton_Files.Name = "RadioButton_Files";
            this.RadioButton_Files.Size = new System.Drawing.Size(188, 29);
            this.RadioButton_Files.TabIndex = 10;
            this.RadioButton_Files.Text = "Output as Files";
            this.RadioButton_Files.UseVisualStyleBackColor = true;
            this.RadioButton_Files.CheckedChanged += new System.EventHandler(this.RadioButton_Files_CheckedChanged);
            // 
            // Button_Embed
            // 
            this.Button_Embed.Location = new System.Drawing.Point(276, 538);
            this.Button_Embed.Name = "Button_Embed";
            this.Button_Embed.Size = new System.Drawing.Size(123, 53);
            this.Button_Embed.TabIndex = 9;
            this.Button_Embed.Text = "Embed";
            this.Button_Embed.UseVisualStyleBackColor = true;
            this.Button_Embed.Click += new System.EventHandler(this.Button_Embed_Click);
            // 
            // Button_Directory
            // 
            this.Button_Directory.Location = new System.Drawing.Point(544, 134);
            this.Button_Directory.Name = "Button_Directory";
            this.Button_Directory.Size = new System.Drawing.Size(123, 53);
            this.Button_Directory.TabIndex = 8;
            this.Button_Directory.Text = "Browse";
            this.Button_Directory.UseVisualStyleBackColor = true;
            this.Button_Directory.Click += new System.EventHandler(this.Button_Directory_Click);
            // 
            // TextBox_DirectoryDir
            // 
            this.TextBox_DirectoryDir.Enabled = false;
            this.TextBox_DirectoryDir.Location = new System.Drawing.Point(135, 145);
            this.TextBox_DirectoryDir.Name = "TextBox_DirectoryDir";
            this.TextBox_DirectoryDir.Size = new System.Drawing.Size(400, 31);
            this.TextBox_DirectoryDir.TabIndex = 7;
            // 
            // Label_Directory
            // 
            this.Label_Directory.AutoSize = true;
            this.Label_Directory.Location = new System.Drawing.Point(19, 148);
            this.Label_Directory.Name = "Label_Directory";
            this.Label_Directory.Size = new System.Drawing.Size(110, 25);
            this.Label_Directory.TabIndex = 6;
            this.Label_Directory.Text = "Directory: ";
            // 
            // Button_StegoList
            // 
            this.Button_StegoList.Location = new System.Drawing.Point(544, 69);
            this.Button_StegoList.Name = "Button_StegoList";
            this.Button_StegoList.Size = new System.Drawing.Size(123, 53);
            this.Button_StegoList.TabIndex = 5;
            this.Button_StegoList.Text = "Browse";
            this.Button_StegoList.UseVisualStyleBackColor = true;
            this.Button_StegoList.Click += new System.EventHandler(this.Button_StegoList_Click);
            // 
            // Button_ImageFile
            // 
            this.Button_ImageFile.Location = new System.Drawing.Point(544, 6);
            this.Button_ImageFile.Name = "Button_ImageFile";
            this.Button_ImageFile.Size = new System.Drawing.Size(123, 53);
            this.Button_ImageFile.TabIndex = 4;
            this.Button_ImageFile.Text = "Browse";
            this.Button_ImageFile.UseVisualStyleBackColor = true;
            this.Button_ImageFile.Click += new System.EventHandler(this.Button_ImageFile_Click);
            // 
            // TextBox_StegoListDir
            // 
            this.TextBox_StegoListDir.Enabled = false;
            this.TextBox_StegoListDir.Location = new System.Drawing.Point(135, 80);
            this.TextBox_StegoListDir.Name = "TextBox_StegoListDir";
            this.TextBox_StegoListDir.Size = new System.Drawing.Size(400, 31);
            this.TextBox_StegoListDir.TabIndex = 3;
            // 
            // TextBox_ImageFileDir
            // 
            this.TextBox_ImageFileDir.Enabled = false;
            this.TextBox_ImageFileDir.Location = new System.Drawing.Point(135, 20);
            this.TextBox_ImageFileDir.Name = "TextBox_ImageFileDir";
            this.TextBox_ImageFileDir.Size = new System.Drawing.Size(400, 31);
            this.TextBox_ImageFileDir.TabIndex = 2;
            // 
            // Label_StegoList
            // 
            this.Label_StegoList.AutoSize = true;
            this.Label_StegoList.Location = new System.Drawing.Point(9, 83);
            this.Label_StegoList.Name = "Label_StegoList";
            this.Label_StegoList.Size = new System.Drawing.Size(120, 25);
            this.Label_StegoList.TabIndex = 1;
            this.Label_StegoList.Text = "Stego List: ";
            // 
            // Label_ImageFile
            // 
            this.Label_ImageFile.AutoSize = true;
            this.Label_ImageFile.Location = new System.Drawing.Point(6, 23);
            this.Label_ImageFile.Name = "Label_ImageFile";
            this.Label_ImageFile.Size = new System.Drawing.Size(123, 25);
            this.Label_ImageFile.TabIndex = 0;
            this.Label_ImageFile.Text = "Image File: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBox_Result);
            this.tabPage2.Controls.Add(this.Label_Result);
            this.tabPage2.Controls.Add(this.Button_Extract);
            this.tabPage2.Controls.Add(this.Button_ImageFileExtract);
            this.tabPage2.Controls.Add(this.TextBox_ImageFileExtractDir);
            this.tabPage2.Controls.Add(this.Label_ImageFileExtract);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(139, 297);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(528, 31);
            this.TextBox_Result.TabIndex = 15;
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(48, 300);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(85, 25);
            this.Label_Result.TabIndex = 14;
            this.Label_Result.Text = "Result: ";
            // 
            // Button_Extract
            // 
            this.Button_Extract.Location = new System.Drawing.Point(269, 395);
            this.Button_Extract.Name = "Button_Extract";
            this.Button_Extract.Size = new System.Drawing.Size(123, 53);
            this.Button_Extract.TabIndex = 13;
            this.Button_Extract.Text = "Extract";
            this.Button_Extract.UseVisualStyleBackColor = true;
            this.Button_Extract.Click += new System.EventHandler(this.Button_Extract_Click);
            // 
            // Button_ImageFileExtract
            // 
            this.Button_ImageFileExtract.Location = new System.Drawing.Point(544, 222);
            this.Button_ImageFileExtract.Name = "Button_ImageFileExtract";
            this.Button_ImageFileExtract.Size = new System.Drawing.Size(123, 53);
            this.Button_ImageFileExtract.TabIndex = 12;
            this.Button_ImageFileExtract.Text = "Browse";
            this.Button_ImageFileExtract.UseVisualStyleBackColor = true;
            this.Button_ImageFileExtract.Click += new System.EventHandler(this.Button_ImageFileExtract_Click);
            // 
            // TextBox_ImageFileExtractDir
            // 
            this.TextBox_ImageFileExtractDir.Enabled = false;
            this.TextBox_ImageFileExtractDir.Location = new System.Drawing.Point(138, 233);
            this.TextBox_ImageFileExtractDir.Name = "TextBox_ImageFileExtractDir";
            this.TextBox_ImageFileExtractDir.Size = new System.Drawing.Size(400, 31);
            this.TextBox_ImageFileExtractDir.TabIndex = 11;
            // 
            // Label_ImageFileExtract
            // 
            this.Label_ImageFileExtract.AutoSize = true;
            this.Label_ImageFileExtract.Location = new System.Drawing.Point(9, 236);
            this.Label_ImageFileExtract.Name = "Label_ImageFileExtract";
            this.Label_ImageFileExtract.Size = new System.Drawing.Size(123, 25);
            this.Label_ImageFileExtract.TabIndex = 10;
            this.Label_ImageFileExtract.Text = "Image File: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 747);
            this.Controls.Add(this.TabControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stegotreon";
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Embed.ResumeLayout(false);
            this.TabPage_Embed.PerformLayout();
            this.GroupBox_StegoType.ResumeLayout(false);
            this.GroupBox_StegoType.PerformLayout();
            this.GroupBox_Naming.ResumeLayout(false);
            this.GroupBox_Naming.PerformLayout();
            this.GroupBox_OutputType.ResumeLayout(false);
            this.GroupBox_OutputType.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Embed;
        private System.Windows.Forms.RadioButton RadioButton_Files;
        private System.Windows.Forms.Button Button_Embed;
        private System.Windows.Forms.Button Button_Directory;
        private System.Windows.Forms.TextBox TextBox_DirectoryDir;
        private System.Windows.Forms.Label Label_Directory;
        private System.Windows.Forms.Button Button_StegoList;
        private System.Windows.Forms.Button Button_ImageFile;
        private System.Windows.Forms.TextBox TextBox_StegoListDir;
        private System.Windows.Forms.TextBox TextBox_ImageFileDir;
        private System.Windows.Forms.Label Label_StegoList;
        private System.Windows.Forms.Label Label_ImageFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Button Button_Extract;
        private System.Windows.Forms.Button Button_ImageFileExtract;
        private System.Windows.Forms.TextBox TextBox_ImageFileExtractDir;
        private System.Windows.Forms.Label Label_ImageFileExtract;
        private System.Windows.Forms.RadioButton RadioButton_Folders;
        private System.Windows.Forms.GroupBox GroupBox_StegoType;
        private System.Windows.Forms.RadioButton RadioButton_GUID;
        private System.Windows.Forms.RadioButton RadioButton_Plaintext;
        private System.Windows.Forms.GroupBox GroupBox_Naming;
        private System.Windows.Forms.RadioButton RadioButton_Original;
        private System.Windows.Forms.RadioButton RadioButton_AppendGUID;
        private System.Windows.Forms.GroupBox GroupBox_OutputType;
        private System.Windows.Forms.ProgressBar EmbedProgressBar;
        private System.Windows.Forms.RadioButton RadioButton_AppendName;
    }
}

