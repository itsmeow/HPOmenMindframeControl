namespace MindframeControl
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.groupBoxCooling = new System.Windows.Forms.GroupBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.CoolingBar = new System.Windows.Forms.TrackBar();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorLengthBox = new System.Windows.Forms.NumericUpDown();
            this.btnColorList = new System.Windows.Forms.Button();
            this.colorModeBox = new System.Windows.Forms.ComboBox();
            this.staticColorPanel = new System.Windows.Forms.Panel();
            this.btnStaticColor = new System.Windows.Forms.Button();
            this.audioGroupBox = new System.Windows.Forms.GroupBox();
            this.encCheckBox = new System.Windows.Forms.CheckBox();
            this.dynamicBassCheckBox = new System.Windows.Forms.CheckBox();
            this.surroundMaxCheckBox = new System.Windows.Forms.CheckBox();
            this.surroundCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.muteSidetoneBox = new System.Windows.Forms.CheckBox();
            this.sidetoneVolumeBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.muteMicrophoneBox = new System.Windows.Forms.CheckBox();
            this.micVolumeBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.muteHeadphoneBox = new System.Windows.Forms.CheckBox();
            this.speakerVolumeBar = new System.Windows.Forms.TrackBar();
            this.headsetBox = new System.Windows.Forms.ComboBox();
            this.lblSelectHeadset = new System.Windows.Forms.Label();
            this.groupBoxCooling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoolingBar)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorLengthBox)).BeginInit();
            this.staticColorPanel.SuspendLayout();
            this.audioGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidetoneVolumeBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micVolumeBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speakerVolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCooling
            // 
            this.groupBoxCooling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBoxCooling.Controls.Add(this.lblMed);
            this.groupBoxCooling.Controls.Add(this.lblOff);
            this.groupBoxCooling.Controls.Add(this.lblMin);
            this.groupBoxCooling.Controls.Add(this.lblMax);
            this.groupBoxCooling.Controls.Add(this.CoolingBar);
            this.groupBoxCooling.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCooling.ForeColor = System.Drawing.Color.Aqua;
            this.groupBoxCooling.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCooling.Name = "groupBoxCooling";
            this.groupBoxCooling.Size = new System.Drawing.Size(175, 199);
            this.groupBoxCooling.TabIndex = 0;
            this.groupBoxCooling.TabStop = false;
            this.groupBoxCooling.Text = "Cooling";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMed.Location = new System.Drawing.Point(57, 75);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(54, 16);
            this.lblMed.TabIndex = 5;
            this.lblMed.Text = "Medium";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOff.Location = new System.Drawing.Point(57, 173);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(24, 16);
            this.lblOff.TabIndex = 4;
            this.lblOff.Text = "Off";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMin.Location = new System.Drawing.Point(57, 124);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(61, 16);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMax.Location = new System.Drawing.Point(57, 25);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(65, 16);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // CoolingBar
            // 
            this.CoolingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CoolingBar.LargeChange = 1;
            this.CoolingBar.Location = new System.Drawing.Point(6, 19);
            this.CoolingBar.Maximum = 3;
            this.CoolingBar.Name = "CoolingBar";
            this.CoolingBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CoolingBar.Size = new System.Drawing.Size(45, 174);
            this.CoolingBar.TabIndex = 1;
            this.CoolingBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.CoolingBar.Scroll += new System.EventHandler(this.CoolingBar_Scroll);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBoxColor.Controls.Add(this.panel1);
            this.groupBoxColor.Controls.Add(this.colorModeBox);
            this.groupBoxColor.Controls.Add(this.staticColorPanel);
            this.groupBoxColor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.ForeColor = System.Drawing.Color.Red;
            this.groupBoxColor.Location = new System.Drawing.Point(193, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(288, 199);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.colorLengthBox);
            this.panel1.Controls.Add(this.btnColorList);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(20, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color Length (ms)";
            // 
            // colorLengthBox
            // 
            this.colorLengthBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLengthBox.Location = new System.Drawing.Point(117, 32);
            this.colorLengthBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.colorLengthBox.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.colorLengthBox.Name = "colorLengthBox";
            this.colorLengthBox.Size = new System.Drawing.Size(128, 22);
            this.colorLengthBox.TabIndex = 2;
            this.colorLengthBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.colorLengthBox.ValueChanged += new System.EventHandler(this.colorLengthBox_ValueChanged);
            // 
            // btnColorList
            // 
            this.btnColorList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColorList.Location = new System.Drawing.Point(6, 3);
            this.btnColorList.Name = "btnColorList";
            this.btnColorList.Size = new System.Drawing.Size(239, 23);
            this.btnColorList.TabIndex = 1;
            this.btnColorList.Text = "Set Color List";
            this.btnColorList.UseVisualStyleBackColor = true;
            this.btnColorList.Click += new System.EventHandler(this.btnColorList_Click);
            // 
            // colorModeBox
            // 
            this.colorModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorModeBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorModeBox.FormattingEnabled = true;
            this.colorModeBox.Items.AddRange(new object[] {
            "Animation",
            "Audio",
            "Static",
            "Off"});
            this.colorModeBox.Location = new System.Drawing.Point(20, 25);
            this.colorModeBox.Name = "colorModeBox";
            this.colorModeBox.Size = new System.Drawing.Size(121, 24);
            this.colorModeBox.TabIndex = 1;
            this.colorModeBox.SelectedIndexChanged += new System.EventHandler(this.colorModeBox_SelectedIndexChanged);
            // 
            // staticColorPanel
            // 
            this.staticColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticColorPanel.Controls.Add(this.btnStaticColor);
            this.staticColorPanel.Location = new System.Drawing.Point(20, 55);
            this.staticColorPanel.Name = "staticColorPanel";
            this.staticColorPanel.Size = new System.Drawing.Size(250, 60);
            this.staticColorPanel.TabIndex = 0;
            // 
            // btnStaticColor
            // 
            this.btnStaticColor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaticColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStaticColor.Location = new System.Drawing.Point(48, 17);
            this.btnStaticColor.Name = "btnStaticColor";
            this.btnStaticColor.Size = new System.Drawing.Size(155, 23);
            this.btnStaticColor.TabIndex = 0;
            this.btnStaticColor.Text = "Set Static Color";
            this.btnStaticColor.UseVisualStyleBackColor = true;
            this.btnStaticColor.Click += new System.EventHandler(this.btnStaticColor_Click);
            // 
            // audioGroupBox
            // 
            this.audioGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.audioGroupBox.Controls.Add(this.encCheckBox);
            this.audioGroupBox.Controls.Add(this.dynamicBassCheckBox);
            this.audioGroupBox.Controls.Add(this.surroundMaxCheckBox);
            this.audioGroupBox.Controls.Add(this.surroundCheckBox);
            this.audioGroupBox.Controls.Add(this.groupBox3);
            this.audioGroupBox.Controls.Add(this.groupBox2);
            this.audioGroupBox.Controls.Add(this.groupBox1);
            this.audioGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.audioGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.audioGroupBox.Location = new System.Drawing.Point(487, 12);
            this.audioGroupBox.Name = "audioGroupBox";
            this.audioGroupBox.Size = new System.Drawing.Size(390, 199);
            this.audioGroupBox.TabIndex = 7;
            this.audioGroupBox.TabStop = false;
            this.audioGroupBox.Text = "Audio";
            // 
            // encCheckBox
            // 
            this.encCheckBox.AutoSize = true;
            this.encCheckBox.Font = new System.Drawing.Font("Arial", 8F);
            this.encCheckBox.Location = new System.Drawing.Point(294, 107);
            this.encCheckBox.Name = "encCheckBox";
            this.encCheckBox.Size = new System.Drawing.Size(84, 32);
            this.encCheckBox.TabIndex = 15;
            this.encCheckBox.Text = "Noise\r\nCancellation";
            this.encCheckBox.UseVisualStyleBackColor = true;
            this.encCheckBox.CheckedChanged += new System.EventHandler(this.EncCheckBox_CheckedChanged);
            // 
            // dynamicBassCheckBox
            // 
            this.dynamicBassCheckBox.AutoSize = true;
            this.dynamicBassCheckBox.Font = new System.Drawing.Font("Arial", 8F);
            this.dynamicBassCheckBox.Location = new System.Drawing.Point(294, 83);
            this.dynamicBassCheckBox.Name = "dynamicBassCheckBox";
            this.dynamicBassCheckBox.Size = new System.Drawing.Size(95, 18);
            this.dynamicBassCheckBox.TabIndex = 14;
            this.dynamicBassCheckBox.Text = "Dynamic Bass";
            this.dynamicBassCheckBox.UseVisualStyleBackColor = true;
            this.dynamicBassCheckBox.CheckedChanged += new System.EventHandler(this.DynamicBassCheckBox_CheckedChanged);
            // 
            // surroundMaxCheckBox
            // 
            this.surroundMaxCheckBox.AutoSize = true;
            this.surroundMaxCheckBox.Font = new System.Drawing.Font("Arial", 8F);
            this.surroundMaxCheckBox.Location = new System.Drawing.Point(294, 59);
            this.surroundMaxCheckBox.Name = "surroundMaxCheckBox";
            this.surroundMaxCheckBox.Size = new System.Drawing.Size(94, 18);
            this.surroundMaxCheckBox.TabIndex = 13;
            this.surroundMaxCheckBox.Text = "Surround Max";
            this.surroundMaxCheckBox.UseVisualStyleBackColor = true;
            this.surroundMaxCheckBox.CheckedChanged += new System.EventHandler(this.SurroundMaxCheckBox_CheckedChanged);
            // 
            // surroundCheckBox
            // 
            this.surroundCheckBox.AutoSize = true;
            this.surroundCheckBox.Font = new System.Drawing.Font("Arial", 8F);
            this.surroundCheckBox.Location = new System.Drawing.Point(294, 25);
            this.surroundCheckBox.Name = "surroundCheckBox";
            this.surroundCheckBox.Size = new System.Drawing.Size(89, 32);
            this.surroundCheckBox.TabIndex = 12;
            this.surroundCheckBox.Text = "7.1 Surround\r\nVirtualization\r\n";
            this.surroundCheckBox.UseVisualStyleBackColor = true;
            this.surroundCheckBox.CheckedChanged += new System.EventHandler(this.SurroundCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.muteSidetoneBox);
            this.groupBox3.Controls.Add(this.sidetoneVolumeBar);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(198, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 173);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sidetone";
            // 
            // muteSidetoneBox
            // 
            this.muteSidetoneBox.AutoSize = true;
            this.muteSidetoneBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteSidetoneBox.Location = new System.Drawing.Point(18, 150);
            this.muteSidetoneBox.Name = "muteSidetoneBox";
            this.muteSidetoneBox.Size = new System.Drawing.Size(49, 18);
            this.muteSidetoneBox.TabIndex = 8;
            this.muteSidetoneBox.Text = "Mute";
            this.muteSidetoneBox.UseVisualStyleBackColor = true;
            this.muteSidetoneBox.CheckedChanged += new System.EventHandler(this.MuteSidetoneBox_CheckedChanged);
            // 
            // sidetoneVolumeBar
            // 
            this.sidetoneVolumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sidetoneVolumeBar.LargeChange = 10;
            this.sidetoneVolumeBar.Location = new System.Drawing.Point(22, 20);
            this.sidetoneVolumeBar.Maximum = 100;
            this.sidetoneVolumeBar.Name = "sidetoneVolumeBar";
            this.sidetoneVolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sidetoneVolumeBar.Size = new System.Drawing.Size(45, 134);
            this.sidetoneVolumeBar.TabIndex = 6;
            this.sidetoneVolumeBar.TickFrequency = 5;
            this.sidetoneVolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sidetoneVolumeBar.Scroll += new System.EventHandler(this.SidetoneVolumeBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.muteMicrophoneBox);
            this.groupBox2.Controls.Add(this.micVolumeBar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(102, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Microphone";
            // 
            // muteMicrophoneBox
            // 
            this.muteMicrophoneBox.AutoSize = true;
            this.muteMicrophoneBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteMicrophoneBox.Location = new System.Drawing.Point(18, 150);
            this.muteMicrophoneBox.Name = "muteMicrophoneBox";
            this.muteMicrophoneBox.Size = new System.Drawing.Size(49, 18);
            this.muteMicrophoneBox.TabIndex = 8;
            this.muteMicrophoneBox.Text = "Mute";
            this.muteMicrophoneBox.UseVisualStyleBackColor = true;
            this.muteMicrophoneBox.CheckedChanged += new System.EventHandler(this.MuteMicrophoneBox_CheckedChanged);
            // 
            // micVolumeBar
            // 
            this.micVolumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.micVolumeBar.LargeChange = 10;
            this.micVolumeBar.Location = new System.Drawing.Point(22, 20);
            this.micVolumeBar.Maximum = 100;
            this.micVolumeBar.Name = "micVolumeBar";
            this.micVolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.micVolumeBar.Size = new System.Drawing.Size(45, 134);
            this.micVolumeBar.TabIndex = 6;
            this.micVolumeBar.TickFrequency = 5;
            this.micVolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.micVolumeBar.Scroll += new System.EventHandler(this.MicVolumeBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.muteHeadphoneBox);
            this.groupBox1.Controls.Add(this.speakerVolumeBar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headphone";
            // 
            // muteHeadphoneBox
            // 
            this.muteHeadphoneBox.AutoSize = true;
            this.muteHeadphoneBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteHeadphoneBox.Location = new System.Drawing.Point(18, 150);
            this.muteHeadphoneBox.Name = "muteHeadphoneBox";
            this.muteHeadphoneBox.Size = new System.Drawing.Size(49, 18);
            this.muteHeadphoneBox.TabIndex = 8;
            this.muteHeadphoneBox.Text = "Mute";
            this.muteHeadphoneBox.UseVisualStyleBackColor = true;
            this.muteHeadphoneBox.CheckedChanged += new System.EventHandler(this.MuteHeadphoneBox_CheckedChanged);
            // 
            // speakerVolumeBar
            // 
            this.speakerVolumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.speakerVolumeBar.LargeChange = 10;
            this.speakerVolumeBar.Location = new System.Drawing.Point(22, 20);
            this.speakerVolumeBar.Maximum = 100;
            this.speakerVolumeBar.Name = "speakerVolumeBar";
            this.speakerVolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speakerVolumeBar.Size = new System.Drawing.Size(45, 134);
            this.speakerVolumeBar.TabIndex = 6;
            this.speakerVolumeBar.TickFrequency = 5;
            this.speakerVolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speakerVolumeBar.Scroll += new System.EventHandler(this.SpeakerVolumeBar_Scroll);
            // 
            // headsetBox
            // 
            this.headsetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headsetBox.FormattingEnabled = true;
            this.headsetBox.Items.AddRange(new object[] {
            "Mindframe",
            "Mindframe Prime"});
            this.headsetBox.Location = new System.Drawing.Point(115, 217);
            this.headsetBox.Name = "headsetBox";
            this.headsetBox.Size = new System.Drawing.Size(121, 21);
            this.headsetBox.TabIndex = 8;
            this.headsetBox.SelectedIndexChanged += new System.EventHandler(this.HeadsetBox_SelectedIndexChanged);
            // 
            // lblSelectHeadset
            // 
            this.lblSelectHeadset.AutoSize = true;
            this.lblSelectHeadset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectHeadset.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelectHeadset.Location = new System.Drawing.Point(12, 218);
            this.lblSelectHeadset.Name = "lblSelectHeadset";
            this.lblSelectHeadset.Size = new System.Drawing.Size(97, 16);
            this.lblSelectHeadset.TabIndex = 6;
            this.lblSelectHeadset.Text = "Select Headset";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(889, 241);
            this.Controls.Add(this.lblSelectHeadset);
            this.Controls.Add(this.headsetBox);
            this.Controls.Add(this.audioGroupBox);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxCooling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainControl";
            this.Text = "HP Omen Mindframe Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainControl_Close);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.groupBoxCooling.ResumeLayout(false);
            this.groupBoxCooling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoolingBar)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorLengthBox)).EndInit();
            this.staticColorPanel.ResumeLayout(false);
            this.audioGroupBox.ResumeLayout(false);
            this.audioGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidetoneVolumeBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micVolumeBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speakerVolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCooling;
        private System.Windows.Forms.TrackBar CoolingBar;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel staticColorPanel;
        private System.Windows.Forms.Button btnStaticColor;
        private System.Windows.Forms.ComboBox colorModeBox;
        private System.Windows.Forms.Button btnColorList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colorLengthBox;
        private System.Windows.Forms.GroupBox audioGroupBox;
        private System.Windows.Forms.TrackBar speakerVolumeBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox muteHeadphoneBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox muteSidetoneBox;
        private System.Windows.Forms.TrackBar sidetoneVolumeBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox muteMicrophoneBox;
        private System.Windows.Forms.TrackBar micVolumeBar;
        private System.Windows.Forms.CheckBox surroundCheckBox;
        private System.Windows.Forms.CheckBox dynamicBassCheckBox;
        private System.Windows.Forms.CheckBox surroundMaxCheckBox;
        private System.Windows.Forms.ComboBox headsetBox;
        private System.Windows.Forms.Label lblSelectHeadset;
        private System.Windows.Forms.CheckBox encCheckBox;
    }
}

