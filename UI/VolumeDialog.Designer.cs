namespace SSR_Music_Packer_GUI;

partial class VolumeDialog {
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
            this.button_Default = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Radio = new System.Windows.Forms.GroupBox();
            this.radioButton_OnlyNonDefault = new System.Windows.Forms.RadioButton();
            this.radioButton_OnlyDefault = new System.Windows.Forms.RadioButton();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.groupBox_Radio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button_Default);
            this.panel1.Controls.Add(this.button_Apply);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown_Volume);
            this.panel1.Controls.Add(this.groupBox_Radio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 93);
            this.panel1.TabIndex = 0;
            // 
            // button_Default
            // 
            this.button_Default.Location = new System.Drawing.Point(224, 36);
            this.button_Default.Name = "button_Default";
            this.button_Default.Size = new System.Drawing.Size(84, 23);
            this.button_Default.TabIndex = 4;
            this.button_Default.Text = "Default";
            this.button_Default.UseVisualStyleBackColor = true;
            this.button_Default.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(224, 65);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(84, 23);
            this.button_Apply.TabIndex = 3;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Volume.Location = new System.Drawing.Point(267, 9);
            this.numericUpDown_Volume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Volume.Name = "numericUpDown_Volume";
            this.numericUpDown_Volume.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown_Volume.TabIndex = 1;
            this.numericUpDown_Volume.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // groupBox_Radio
            // 
            this.groupBox_Radio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Radio.Controls.Add(this.radioButton_OnlyNonDefault);
            this.groupBox_Radio.Controls.Add(this.radioButton_OnlyDefault);
            this.groupBox_Radio.Controls.Add(this.radioButton_All);
            this.groupBox_Radio.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Radio.Name = "groupBox_Radio";
            this.groupBox_Radio.Size = new System.Drawing.Size(215, 87);
            this.groupBox_Radio.TabIndex = 0;
            this.groupBox_Radio.TabStop = false;
            this.groupBox_Radio.Text = "Apply to...";
            // 
            // radioButton_OnlyNonDefault
            // 
            this.radioButton_OnlyNonDefault.AutoSize = true;
            this.radioButton_OnlyNonDefault.Location = new System.Drawing.Point(6, 62);
            this.radioButton_OnlyNonDefault.Name = "radioButton_OnlyNonDefault";
            this.radioButton_OnlyNonDefault.Size = new System.Drawing.Size(201, 17);
            this.radioButton_OnlyNonDefault.TabIndex = 2;
            this.radioButton_OnlyNonDefault.Text = "Only levels using non-default volume";
            this.radioButton_OnlyNonDefault.UseVisualStyleBackColor = true;
            this.radioButton_OnlyNonDefault.CheckedChanged += new System.EventHandler(this.radioButton_OnlyNonDefault_CheckedChanged);
            // 
            // radioButton_OnlyDefault
            // 
            this.radioButton_OnlyDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OnlyDefault.AutoSize = true;
            this.radioButton_OnlyDefault.Location = new System.Drawing.Point(6, 39);
            this.radioButton_OnlyDefault.Name = "radioButton_OnlyDefault";
            this.radioButton_OnlyDefault.Size = new System.Drawing.Size(179, 17);
            this.radioButton_OnlyDefault.TabIndex = 1;
            this.radioButton_OnlyDefault.Text = "Only levels using default volume";
            this.radioButton_OnlyDefault.UseVisualStyleBackColor = true;
            this.radioButton_OnlyDefault.CheckedChanged += new System.EventHandler(this.radioButton_OnlyDefault_CheckedChanged);
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Checked = true;
            this.radioButton_All.Location = new System.Drawing.Point(6, 16);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(66, 17);
            this.radioButton_All.TabIndex = 0;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "All levels";
            this.radioButton_All.UseVisualStyleBackColor = true;
            this.radioButton_All.CheckedChanged += new System.EventHandler(this.radioButton_All_CheckedChanged);
            // 
            // VolumeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 117);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(351, 149);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 149);
            this.Name = "VolumeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Volume of Multiple Levels";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.groupBox_Radio.ResumeLayout(false);
            this.groupBox_Radio.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Label label1;
    private NumericUpDown numericUpDown_Volume;
    private GroupBox groupBox_Radio;
    private RadioButton radioButton_OnlyNonDefault;
    private RadioButton radioButton_OnlyDefault;
    private RadioButton radioButton_All;
    private Button button_Default;
    private Button button_Apply;
}