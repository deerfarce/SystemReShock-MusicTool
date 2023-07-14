namespace SSR_Music_Packer_GUI;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ClearPaths = new System.Windows.Forms.Button();
            this.button_AutoLoop = new System.Windows.Forms.Button();
            this.groupBox_MusicFiles = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_MainTrack = new System.Windows.Forms.GroupBox();
            this.label_MainLoopTime = new System.Windows.Forms.Label();
            this.numericUpDown_MainMeasures = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Clear_MainTrack = new System.Windows.Forms.Button();
            this.label_MainTrack_Filename = new System.Windows.Forms.Label();
            this.button_Select_MainTrack = new System.Windows.Forms.Button();
            this.groupBox_IntroTrack = new System.Windows.Forms.GroupBox();
            this.label_IntroLoopTime = new System.Windows.Forms.Label();
            this.numericUpDown_IntroMeasures = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Clear_IntroTrack = new System.Windows.Forms.Button();
            this.label_IntroTrack_Filename = new System.Windows.Forms.Label();
            this.button_Select_IntroTrack = new System.Windows.Forms.Button();
            this.groupBox_Levels = new System.Windows.Forms.GroupBox();
            this.groupBox_MusicSettings = new System.Windows.Forms.GroupBox();
            this.label_BPM = new System.Windows.Forms.Label();
            this.numericUpDown_BPM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBox_PreDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numBox_PostDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBox_UseOtherLevel = new System.Windows.Forms.CheckBox();
            this.combobox_UseFromOtherLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFromJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Recents = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProjectAspakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVolumeOfAllLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_JSON = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_JSON = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog_SavePak = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_MusicFiles.SuspendLayout();
            this.groupBox_MainTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MainMeasures)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox_IntroTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntroMeasures)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox_Levels.SuspendLayout();
            this.groupBox_MusicSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_PreDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_PostDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button_ClearPaths);
            this.flowLayoutPanel1.Controls.Add(this.button_AutoLoop);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button_ClearPaths
            // 
            this.button_ClearPaths.AutoSize = true;
            this.button_ClearPaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_ClearPaths.Location = new System.Drawing.Point(3, 3);
            this.button_ClearPaths.Name = "button_ClearPaths";
            this.button_ClearPaths.Size = new System.Drawing.Size(91, 23);
            this.button_ClearPaths.TabIndex = 5;
            this.button_ClearPaths.Text = "Clear Both Files";
            this.button_ClearPaths.UseVisualStyleBackColor = true;
            this.button_ClearPaths.Click += new System.EventHandler(this.button_ClearPaths_Click);
            // 
            // button_AutoLoop
            // 
            this.button_AutoLoop.AutoSize = true;
            this.button_AutoLoop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_AutoLoop.Location = new System.Drawing.Point(100, 3);
            this.button_AutoLoop.Name = "button_AutoLoop";
            this.button_AutoLoop.Size = new System.Drawing.Size(122, 23);
            this.button_AutoLoop.TabIndex = 6;
            this.button_AutoLoop.Text = "Auto Loop (Main only)";
            this.toolTip1.SetToolTip(this.button_AutoLoop, "Automatically determines the timing for the Main track.\r\nThe BPM and measures won" +
        "\'t actually match the music,\r\nbut it should at least allow the track to loop nea" +
        "rly perfectly.");
            this.button_AutoLoop.UseVisualStyleBackColor = true;
            this.button_AutoLoop.Click += new System.EventHandler(this.button_AutoLoop_Click);
            // 
            // groupBox_MusicFiles
            // 
            this.groupBox_MusicFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_MusicFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_MusicFiles.Controls.Add(this.label5);
            this.groupBox_MusicFiles.Controls.Add(this.label4);
            this.groupBox_MusicFiles.Controls.Add(this.groupBox_MainTrack);
            this.groupBox_MusicFiles.Controls.Add(this.groupBox_IntroTrack);
            this.groupBox_MusicFiles.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_MusicFiles.Location = new System.Drawing.Point(140, 3);
            this.groupBox_MusicFiles.Name = "groupBox_MusicFiles";
            this.groupBox_MusicFiles.Size = new System.Drawing.Size(633, 173);
            this.groupBox_MusicFiles.TabIndex = 4;
            this.groupBox_MusicFiles.TabStop = false;
            this.groupBox_MusicFiles.Text = "Reactor - Music Files";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(564, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Play Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "Amount of time used in determining loop timing.\r\nCalculated using BPM and Measure" +
        "s.");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(508, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Measures";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_MainTrack
            // 
            this.groupBox_MainTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_MainTrack.Controls.Add(this.label_MainLoopTime);
            this.groupBox_MainTrack.Controls.Add(this.numericUpDown_MainMeasures);
            this.groupBox_MainTrack.Controls.Add(this.panel3);
            this.groupBox_MainTrack.Location = new System.Drawing.Point(6, 79);
            this.groupBox_MainTrack.Name = "groupBox_MainTrack";
            this.groupBox_MainTrack.Size = new System.Drawing.Size(621, 50);
            this.groupBox_MainTrack.TabIndex = 7;
            this.groupBox_MainTrack.TabStop = false;
            this.groupBox_MainTrack.Text = "Main Track";
            // 
            // label_MainLoopTime
            // 
            this.label_MainLoopTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MainLoopTime.BackColor = System.Drawing.SystemColors.Control;
            this.label_MainLoopTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_MainLoopTime.Location = new System.Drawing.Point(558, 20);
            this.label_MainLoopTime.Name = "label_MainLoopTime";
            this.label_MainLoopTime.Size = new System.Drawing.Size(61, 21);
            this.label_MainLoopTime.TabIndex = 13;
            this.label_MainLoopTime.Text = "176.2221";
            this.label_MainLoopTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_MainMeasures
            // 
            this.numericUpDown_MainMeasures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_MainMeasures.Location = new System.Drawing.Point(508, 20);
            this.numericUpDown_MainMeasures.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_MainMeasures.Name = "numericUpDown_MainMeasures";
            this.numericUpDown_MainMeasures.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown_MainMeasures.TabIndex = 12;
            this.toolTip1.SetToolTip(this.numericUpDown_MainMeasures, "Length of the Main track in measures.\r\nUsed to determine when the main track shou" +
        "ld play again (loop).\r\n4/4 is assumed.");
            this.numericUpDown_MainMeasures.ValueChanged += new System.EventHandler(this.numericUpDown_MainMeasures_ValueChanged);
            this.numericUpDown_MainMeasures.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_MainMeasures_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_Clear_MainTrack);
            this.panel3.Controls.Add(this.label_MainTrack_Filename);
            this.panel3.Controls.Add(this.button_Select_MainTrack);
            this.panel3.Location = new System.Drawing.Point(6, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 24);
            this.panel3.TabIndex = 5;
            // 
            // button_Clear_MainTrack
            // 
            this.button_Clear_MainTrack.AutoSize = true;
            this.button_Clear_MainTrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Clear_MainTrack.Location = new System.Drawing.Point(373, 0);
            this.button_Clear_MainTrack.Name = "button_Clear_MainTrack";
            this.button_Clear_MainTrack.Size = new System.Drawing.Size(42, 20);
            this.button_Clear_MainTrack.TabIndex = 7;
            this.button_Clear_MainTrack.Text = "Clear";
            this.button_Clear_MainTrack.UseVisualStyleBackColor = true;
            this.button_Clear_MainTrack.Click += new System.EventHandler(this.button_Clear_MainTrack_Click);
            // 
            // label_MainTrack_Filename
            // 
            this.label_MainTrack_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MainTrack_Filename.AutoEllipsis = true;
            this.label_MainTrack_Filename.BackColor = System.Drawing.Color.Transparent;
            this.label_MainTrack_Filename.Location = new System.Drawing.Point(3, 3);
            this.label_MainTrack_Filename.Name = "label_MainTrack_Filename";
            this.label_MainTrack_Filename.Size = new System.Drawing.Size(364, 15);
            this.label_MainTrack_Filename.TabIndex = 6;
            this.label_MainTrack_Filename.Text = "filename";
            this.label_MainTrack_Filename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Select_MainTrack
            // 
            this.button_Select_MainTrack.AutoSize = true;
            this.button_Select_MainTrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Select_MainTrack.Location = new System.Drawing.Point(415, 0);
            this.button_Select_MainTrack.Name = "button_Select_MainTrack";
            this.button_Select_MainTrack.Size = new System.Drawing.Size(77, 20);
            this.button_Select_MainTrack.TabIndex = 5;
            this.button_Select_MainTrack.Text = "Select File...";
            this.button_Select_MainTrack.UseVisualStyleBackColor = true;
            this.button_Select_MainTrack.Click += new System.EventHandler(this.button_Select_MainTrack_Click);
            // 
            // groupBox_IntroTrack
            // 
            this.groupBox_IntroTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_IntroTrack.Controls.Add(this.label_IntroLoopTime);
            this.groupBox_IntroTrack.Controls.Add(this.numericUpDown_IntroMeasures);
            this.groupBox_IntroTrack.Controls.Add(this.panel2);
            this.groupBox_IntroTrack.Location = new System.Drawing.Point(6, 23);
            this.groupBox_IntroTrack.Name = "groupBox_IntroTrack";
            this.groupBox_IntroTrack.Size = new System.Drawing.Size(621, 50);
            this.groupBox_IntroTrack.TabIndex = 6;
            this.groupBox_IntroTrack.TabStop = false;
            this.groupBox_IntroTrack.Text = "Intro (optional)";
            // 
            // label_IntroLoopTime
            // 
            this.label_IntroLoopTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IntroLoopTime.BackColor = System.Drawing.SystemColors.Control;
            this.label_IntroLoopTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_IntroLoopTime.Location = new System.Drawing.Point(558, 20);
            this.label_IntroLoopTime.Name = "label_IntroLoopTime";
            this.label_IntroLoopTime.Size = new System.Drawing.Size(61, 21);
            this.label_IntroLoopTime.TabIndex = 12;
            this.label_IntroLoopTime.Text = "176.2221";
            this.label_IntroLoopTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_IntroMeasures
            // 
            this.numericUpDown_IntroMeasures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_IntroMeasures.Location = new System.Drawing.Point(508, 20);
            this.numericUpDown_IntroMeasures.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_IntroMeasures.Name = "numericUpDown_IntroMeasures";
            this.numericUpDown_IntroMeasures.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown_IntroMeasures.TabIndex = 11;
            this.toolTip1.SetToolTip(this.numericUpDown_IntroMeasures, "Length of the Intro track in measures.\r\nUsed to determine when the main track sho" +
        "uld begin.\r\n4/4 is assumed.");
            this.numericUpDown_IntroMeasures.ValueChanged += new System.EventHandler(this.numericUpDown_IntroMeasures_ValueChanged);
            this.numericUpDown_IntroMeasures.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_IntroMeasures_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_Clear_IntroTrack);
            this.panel2.Controls.Add(this.label_IntroTrack_Filename);
            this.panel2.Controls.Add(this.button_Select_IntroTrack);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 24);
            this.panel2.TabIndex = 5;
            // 
            // button_Clear_IntroTrack
            // 
            this.button_Clear_IntroTrack.AutoSize = true;
            this.button_Clear_IntroTrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Clear_IntroTrack.Location = new System.Drawing.Point(373, 0);
            this.button_Clear_IntroTrack.Name = "button_Clear_IntroTrack";
            this.button_Clear_IntroTrack.Size = new System.Drawing.Size(42, 20);
            this.button_Clear_IntroTrack.TabIndex = 7;
            this.button_Clear_IntroTrack.Text = "Clear";
            this.button_Clear_IntroTrack.UseVisualStyleBackColor = true;
            this.button_Clear_IntroTrack.Click += new System.EventHandler(this.button_Clear_IntroTrack_Click);
            // 
            // label_IntroTrack_Filename
            // 
            this.label_IntroTrack_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IntroTrack_Filename.AutoEllipsis = true;
            this.label_IntroTrack_Filename.BackColor = System.Drawing.Color.Transparent;
            this.label_IntroTrack_Filename.Location = new System.Drawing.Point(3, 3);
            this.label_IntroTrack_Filename.Name = "label_IntroTrack_Filename";
            this.label_IntroTrack_Filename.Size = new System.Drawing.Size(364, 15);
            this.label_IntroTrack_Filename.TabIndex = 6;
            this.label_IntroTrack_Filename.Text = "filename";
            this.label_IntroTrack_Filename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Select_IntroTrack
            // 
            this.button_Select_IntroTrack.AutoSize = true;
            this.button_Select_IntroTrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Select_IntroTrack.Location = new System.Drawing.Point(415, 0);
            this.button_Select_IntroTrack.Name = "button_Select_IntroTrack";
            this.button_Select_IntroTrack.Size = new System.Drawing.Size(77, 20);
            this.button_Select_IntroTrack.TabIndex = 5;
            this.button_Select_IntroTrack.Text = "Select File...";
            this.button_Select_IntroTrack.UseVisualStyleBackColor = true;
            this.button_Select_IntroTrack.Click += new System.EventHandler(this.button_Select_IntroTrack_Click);
            // 
            // groupBox_Levels
            // 
            this.groupBox_Levels.Controls.Add(this.listBox1);
            this.groupBox_Levels.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Levels.Name = "groupBox_Levels";
            this.groupBox_Levels.Size = new System.Drawing.Size(131, 247);
            this.groupBox_Levels.TabIndex = 5;
            this.groupBox_Levels.TabStop = false;
            this.groupBox_Levels.Text = "Decks/Scenes";
            // 
            // groupBox_MusicSettings
            // 
            this.groupBox_MusicSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_MusicSettings.Controls.Add(this.label_BPM);
            this.groupBox_MusicSettings.Controls.Add(this.numericUpDown_BPM);
            this.groupBox_MusicSettings.Controls.Add(this.label3);
            this.groupBox_MusicSettings.Controls.Add(this.numBox_PreDelay);
            this.groupBox_MusicSettings.Controls.Add(this.label2);
            this.groupBox_MusicSettings.Controls.Add(this.numBox_PostDelay);
            this.groupBox_MusicSettings.Controls.Add(this.checkBox_UseOtherLevel);
            this.groupBox_MusicSettings.Controls.Add(this.combobox_UseFromOtherLevel);
            this.groupBox_MusicSettings.Controls.Add(this.label1);
            this.groupBox_MusicSettings.Controls.Add(this.numericUpDown_Volume);
            this.groupBox_MusicSettings.Location = new System.Drawing.Point(140, 182);
            this.groupBox_MusicSettings.Name = "groupBox_MusicSettings";
            this.groupBox_MusicSettings.Size = new System.Drawing.Size(633, 68);
            this.groupBox_MusicSettings.TabIndex = 6;
            this.groupBox_MusicSettings.TabStop = false;
            this.groupBox_MusicSettings.Text = "Reactor - Music Settings";
            // 
            // label_BPM
            // 
            this.label_BPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_BPM.AutoSize = true;
            this.label_BPM.Location = new System.Drawing.Point(204, 25);
            this.label_BPM.Name = "label_BPM";
            this.label_BPM.Size = new System.Drawing.Size(27, 13);
            this.label_BPM.TabIndex = 10;
            this.label_BPM.Text = "BPM";
            this.label_BPM.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numericUpDown_BPM
            // 
            this.numericUpDown_BPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_BPM.DecimalPlaces = 4;
            this.numericUpDown_BPM.Location = new System.Drawing.Point(183, 41);
            this.numericUpDown_BPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_BPM.Name = "numericUpDown_BPM";
            this.numericUpDown_BPM.Size = new System.Drawing.Size(72, 21);
            this.numericUpDown_BPM.TabIndex = 9;
            this.numericUpDown_BPM.ValueChanged += new System.EventHandler(this.numericUpDown_BPM_ValueChanged);
            this.numericUpDown_BPM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_BPM_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Post-Delay (measures)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBox_PreDelay
            // 
            this.numBox_PreDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBox_PreDelay.Location = new System.Drawing.Point(578, 17);
            this.numBox_PreDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBox_PreDelay.Name = "numBox_PreDelay";
            this.numBox_PreDelay.Size = new System.Drawing.Size(49, 21);
            this.numBox_PreDelay.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numBox_PreDelay, "Amount of measures to wait before\r\nthe first track (intro or main) to begin\r\nplay" +
        "ing music.");
            this.numBox_PreDelay.ValueChanged += new System.EventHandler(this.numBox_PreDelay_ValueChanged);
            this.numBox_PreDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numBox_PreDelay_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pre-Delay (measures)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBox_PostDelay
            // 
            this.numBox_PostDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numBox_PostDelay.Location = new System.Drawing.Point(578, 41);
            this.numBox_PostDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBox_PostDelay.Name = "numBox_PostDelay";
            this.numBox_PostDelay.Size = new System.Drawing.Size(49, 21);
            this.numBox_PostDelay.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numBox_PostDelay, "Amount of measures to wait after the\r\nmain track to begin the next loop.");
            this.numBox_PostDelay.ValueChanged += new System.EventHandler(this.numBox_PostDelay_ValueChanged);
            this.numBox_PostDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numBox_PostDelay_KeyUp);
            // 
            // checkBox_UseOtherLevel
            // 
            this.checkBox_UseOtherLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_UseOtherLevel.AutoSize = true;
            this.checkBox_UseOtherLevel.Location = new System.Drawing.Point(6, 21);
            this.checkBox_UseOtherLevel.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_UseOtherLevel.Name = "checkBox_UseOtherLevel";
            this.checkBox_UseOtherLevel.Size = new System.Drawing.Size(110, 17);
            this.checkBox_UseOtherLevel.TabIndex = 4;
            this.checkBox_UseOtherLevel.Text = "Use music from...";
            this.checkBox_UseOtherLevel.UseVisualStyleBackColor = true;
            this.checkBox_UseOtherLevel.CheckStateChanged += new System.EventHandler(this.checkBox_UseOtherLevel_CheckStateChanged);
            // 
            // combobox_UseFromOtherLevel
            // 
            this.combobox_UseFromOtherLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combobox_UseFromOtherLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_UseFromOtherLevel.Enabled = false;
            this.combobox_UseFromOtherLevel.FormattingEnabled = true;
            this.combobox_UseFromOtherLevel.Location = new System.Drawing.Point(6, 41);
            this.combobox_UseFromOtherLevel.Name = "combobox_UseFromOtherLevel";
            this.combobox_UseFromOtherLevel.Size = new System.Drawing.Size(121, 21);
            this.combobox_UseFromOtherLevel.TabIndex = 2;
            this.combobox_UseFromOtherLevel.SelectedValueChanged += new System.EventHandler(this.combobox_UseFromOtherLevel_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_Volume.Location = new System.Drawing.Point(133, 41);
            this.numericUpDown_Volume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Volume.Name = "numericUpDown_Volume";
            this.numericUpDown_Volume.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown_Volume.TabIndex = 0;
            this.numericUpDown_Volume.ValueChanged += new System.EventHandler(this.numericUpDown_Volume_ValueChanged);
            this.numericUpDown_Volume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_Volume_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ogg";
            this.openFileDialog1.Filter = "Music files (.ogg)|*.ogg";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_New,
            this.openProjectFromJSONToolStripMenuItem,
            this.toolStripMenuItem_Recents,
            this.toolStripMenuItem1,
            this.saveProjectAsJSONToolStripMenuItem,
            this.exportProjectAspakToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.testToolStripMenuItem.Text = "File";
            // 
            // openProjectFromJSONToolStripMenuItem
            // 
            this.openProjectFromJSONToolStripMenuItem.Name = "openProjectFromJSONToolStripMenuItem";
            this.openProjectFromJSONToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openProjectFromJSONToolStripMenuItem.Text = "Open Project...";
            this.openProjectFromJSONToolStripMenuItem.Click += new System.EventHandler(this.openProjectFromJSONToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Recents
            // 
            this.toolStripMenuItem_Recents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.toolStripMenuItem_Recents.Name = "toolStripMenuItem_Recents";
            this.toolStripMenuItem_Recents.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem_Recents.Text = "Recent Projects";
            this.toolStripMenuItem_Recents.DropDownOpening += new System.EventHandler(this.toolStripMenuItem_Recents_DropDownOpening);
            this.toolStripMenuItem_Recents.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem_Recents_DropDownItemClicked);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Enabled = false;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.noneToolStripMenuItem.Text = "(none)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem1.Text = "Save Project";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveProjectAsJSONToolStripMenuItem
            // 
            this.saveProjectAsJSONToolStripMenuItem.Name = "saveProjectAsJSONToolStripMenuItem";
            this.saveProjectAsJSONToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveProjectAsJSONToolStripMenuItem.Text = "Save Project as...";
            this.saveProjectAsJSONToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsJSONToolStripMenuItem_Click);
            // 
            // exportProjectAspakToolStripMenuItem
            // 
            this.exportProjectAspakToolStripMenuItem.Name = "exportProjectAspakToolStripMenuItem";
            this.exportProjectAspakToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportProjectAspakToolStripMenuItem.Text = "Export Project as .pak...";
            this.exportProjectAspakToolStripMenuItem.Click += new System.EventHandler(this.exportProjectAspakToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setVolumeOfAllLevelsToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setVolumeOfAllLevelsToolStripMenuItem
            // 
            this.setVolumeOfAllLevelsToolStripMenuItem.Name = "setVolumeOfAllLevelsToolStripMenuItem";
            this.setVolumeOfAllLevelsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.setVolumeOfAllLevelsToolStripMenuItem.Text = "Set Volume of All Levels...";
            this.setVolumeOfAllLevelsToolStripMenuItem.Click += new System.EventHandler(this.setVolumeOfAllLevelsToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox_Levels);
            this.panel1.Controls.Add(this.groupBox_MusicSettings);
            this.panel1.Controls.Add(this.groupBox_MusicFiles);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 252);
            this.panel1.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // openFileDialog_JSON
            // 
            this.openFileDialog_JSON.DefaultExt = "sshockmusic";
            this.openFileDialog_JSON.Filter = "Music Pack Project|*.sshockmusic";
            this.openFileDialog_JSON.InitialDirectory = ".";
            // 
            // saveFileDialog_JSON
            // 
            this.saveFileDialog_JSON.DefaultExt = "sshockmusic";
            this.saveFileDialog_JSON.Filter = "Music Pack Project|*.sshockmusic";
            this.saveFileDialog_JSON.InitialDirectory = ".";
            this.saveFileDialog_JSON.RestoreDirectory = true;
            // 
            // saveFileDialog_SavePak
            // 
            this.saveFileDialog_SavePak.DefaultExt = "pak";
            this.saveFileDialog_SavePak.FileName = "MusicMod_P";
            this.saveFileDialog_SavePak.Filter = ".pak file|*.pak";
            this.saveFileDialog_SavePak.RestoreDirectory = true;
            // 
            // toolStripMenuItem_New
            // 
            this.toolStripMenuItem_New.Name = "toolStripMenuItem_New";
            this.toolStripMenuItem_New.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem_New.Text = "New Empty Project";
            this.toolStripMenuItem_New.Click += new System.EventHandler(this.toolStripMenuItem_New_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 328);
            this.MinimumSize = new System.Drawing.Size(660, 328);
            this.Name = "MainForm";
            this.Text = "System ReShock Music Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox_MusicFiles.ResumeLayout(false);
            this.groupBox_MainTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MainMeasures)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox_IntroTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntroMeasures)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_Levels.ResumeLayout(false);
            this.groupBox_MusicSettings.ResumeLayout(false);
            this.groupBox_MusicSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_PreDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_PostDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ListBox listBox1;
    private FlowLayoutPanel flowLayoutPanel1;
    private GroupBox groupBox_MusicFiles;
    private GroupBox groupBox_Levels;
    private GroupBox groupBox_MusicSettings;
    private CheckBox checkBox_UseOtherLevel;
    private ComboBox combobox_UseFromOtherLevel;
    private Label label1;
    private NumericUpDown numericUpDown_Volume;
    private OpenFileDialog openFileDialog1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem testToolStripMenuItem;
    private Panel panel1;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem exportProjectAspakToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private Panel panel2;
    private Button button_Select_IntroTrack;
    private GroupBox groupBox_IntroTrack;
    private Label label_IntroTrack_Filename;
    private GroupBox groupBox_MainTrack;
    private Panel panel3;
    private Button button_Clear_MainTrack;
    private Label label_MainTrack_Filename;
    private Button button_Select_MainTrack;
    private Button button_Clear_IntroTrack;
    private Label label3;
    private NumericUpDown numBox_PreDelay;
    private Label label2;
    private NumericUpDown numBox_PostDelay;
    private ToolTip toolTip1;
    private ToolStripMenuItem setVolumeOfAllLevelsToolStripMenuItem;
    private Label label_BPM;
    private NumericUpDown numericUpDown_BPM;
    private Label label4;
    private NumericUpDown numericUpDown_MainMeasures;
    private NumericUpDown numericUpDown_IntroMeasures;
    private Button button_ClearPaths;
    private ToolStripMenuItem saveProjectAsJSONToolStripMenuItem;
    private ToolStripMenuItem openProjectFromJSONToolStripMenuItem;
    private OpenFileDialog openFileDialog_JSON;
    private SaveFileDialog saveFileDialog_JSON;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem preferencesToolStripMenuItem;
    private Label label_MainLoopTime;
    private Label label_IntroLoopTime;
    private Label label5;
    private SaveFileDialog saveFileDialog_SavePak;
    private Button button_AutoLoop;
    private ToolStripMenuItem toolStripMenuItem_Recents;
    private ToolStripMenuItem noneToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem_New;
}
