namespace SSR_Music_Packer_GUI;

partial class PreferencesDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_HidePakWarnings = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox_DisableMFDDucking = new System.Windows.Forms.CheckBox();
            this.checkBox_ExportSeparately = new System.Windows.Forms.CheckBox();
            this.checkBox_ExportAsFolder = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_ShowFullPaths = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_RepakPath = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBox_HidePakWarnings);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.checkBox_DisableMFDDucking);
            this.panel1.Controls.Add(this.checkBox_ExportSeparately);
            this.panel1.Controls.Add(this.checkBox_ExportAsFolder);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.checkBox_ShowFullPaths);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 199);
            this.panel1.TabIndex = 0;
            // 
            // checkBox_HidePakWarnings
            // 
            this.checkBox_HidePakWarnings.AutoSize = true;
            this.checkBox_HidePakWarnings.Location = new System.Drawing.Point(9, 72);
            this.checkBox_HidePakWarnings.Name = "checkBox_HidePakWarnings";
            this.checkBox_HidePakWarnings.Size = new System.Drawing.Size(157, 17);
            this.checkBox_HidePakWarnings.TabIndex = 9;
            this.checkBox_HidePakWarnings.Text = "Hide skipped level warnings";
            this.checkBox_HidePakWarnings.UseVisualStyleBackColor = true;
            this.checkBox_HidePakWarnings.CheckedChanged += new System.EventHandler(this.checkBox_HidePakWarnings_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Location = new System.Drawing.Point(415, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 37);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Download repak\r\nfrom GitHub";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox_DisableMFDDucking
            // 
            this.checkBox_DisableMFDDucking.AutoSize = true;
            this.checkBox_DisableMFDDucking.Location = new System.Drawing.Point(9, 26);
            this.checkBox_DisableMFDDucking.Name = "checkBox_DisableMFDDucking";
            this.checkBox_DisableMFDDucking.Size = new System.Drawing.Size(308, 17);
            this.checkBox_DisableMFDDucking.TabIndex = 7;
            this.checkBox_DisableMFDDucking.Text = "In-Game Patch: Disable audio ducking when MFD is opened";
            this.checkBox_DisableMFDDucking.UseVisualStyleBackColor = true;
            this.checkBox_DisableMFDDucking.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_ExportSeparately
            // 
            this.checkBox_ExportSeparately.AutoSize = true;
            this.checkBox_ExportSeparately.Location = new System.Drawing.Point(9, 49);
            this.checkBox_ExportSeparately.Name = "checkBox_ExportSeparately";
            this.checkBox_ExportSeparately.Size = new System.Drawing.Size(163, 17);
            this.checkBox_ExportSeparately.TabIndex = 6;
            this.checkBox_ExportSeparately.Text = "Export each level separately";
            this.checkBox_ExportSeparately.UseVisualStyleBackColor = true;
            this.checkBox_ExportSeparately.CheckedChanged += new System.EventHandler(this.checkBox_ExportSeparately_CheckedChanged);
            // 
            // checkBox_ExportAsFolder
            // 
            this.checkBox_ExportAsFolder.AutoSize = true;
            this.checkBox_ExportAsFolder.Location = new System.Drawing.Point(9, 95);
            this.checkBox_ExportAsFolder.Name = "checkBox_ExportAsFolder";
            this.checkBox_ExportAsFolder.Size = new System.Drawing.Size(246, 17);
            this.checkBox_ExportAsFolder.TabIndex = 5;
            this.checkBox_ExportAsFolder.Text = "Export as folder instead of .pak (skip packing)\r\n";
            this.checkBox_ExportAsFolder.UseVisualStyleBackColor = true;
            this.checkBox_ExportAsFolder.CheckedChanged += new System.EventHandler(this.checkBox_ExportAsFolder_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(433, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_ShowFullPaths
            // 
            this.checkBox_ShowFullPaths.AutoSize = true;
            this.checkBox_ShowFullPaths.Location = new System.Drawing.Point(9, 3);
            this.checkBox_ShowFullPaths.Name = "checkBox_ShowFullPaths";
            this.checkBox_ShowFullPaths.Size = new System.Drawing.Size(145, 17);
            this.checkBox_ShowFullPaths.TabIndex = 2;
            this.checkBox_ShowFullPaths.Text = "Show full music file paths";
            this.checkBox_ShowFullPaths.UseVisualStyleBackColor = true;
            this.checkBox_ShowFullPaths.CheckedChanged += new System.EventHandler(this.checkBox_ShowFullPaths_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "repak.exe Path";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label_RepakPath);
            this.panel3.Location = new System.Drawing.Point(6, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 23);
            this.panel3.TabIndex = 0;
            // 
            // label_RepakPath
            // 
            this.label_RepakPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RepakPath.Location = new System.Drawing.Point(3, 3);
            this.label_RepakPath.Name = "label_RepakPath";
            this.label_RepakPath.Size = new System.Drawing.Size(400, 16);
            this.label_RepakPath.TabIndex = 0;
            this.label_RepakPath.Text = "<no file selected>";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(457, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(422, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 44);
            this.panel2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "repak.exe|repak.exe";
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 223);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PreferencesDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreferencesDialog_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Button button2;
    private Button button1;
    private Panel panel3;
    private GroupBox groupBox1;
    private CheckBox checkBox_ShowFullPaths;
    private Button button3;
    private Label label_RepakPath;
    private OpenFileDialog openFileDialog1;
    private CheckBox checkBox_ExportSeparately;
    private CheckBox checkBox_ExportAsFolder;
    private CheckBox checkBox_DisableMFDDucking;
    private LinkLabel linkLabel1;
    private CheckBox checkBox_HidePakWarnings;
}