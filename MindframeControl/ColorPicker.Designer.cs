namespace MindframeControl
{
    partial class ColorPicker
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
            this.colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.colorEditorManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.colorEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorGrid = new Cyotek.Windows.Forms.ColorGrid();
            this.SuspendLayout();
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(12, 12);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(212, 212);
            this.colorWheel.TabIndex = 0;
            // 
            // colorEditorManager
            // 
            this.colorEditorManager.ColorEditor = this.colorEditor;
            this.colorEditorManager.ColorGrid = this.colorGrid;
            this.colorEditorManager.ColorWheel = this.colorWheel;
            this.colorEditorManager.ColorChanged += new System.EventHandler(this.colorEditorManager_ColorChanged);
            // 
            // colorEditor
            // 
            this.colorEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.colorEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorEditor.Location = new System.Drawing.Point(230, 12);
            this.colorEditor.MaximumSize = new System.Drawing.Size(277, 212);
            this.colorEditor.MinimumSize = new System.Drawing.Size(277, 212);
            this.colorEditor.Name = "colorEditor";
            this.colorEditor.ShowAlphaChannel = false;
            this.colorEditor.Size = new System.Drawing.Size(277, 212);
            this.colorEditor.TabIndex = 1;
            // 
            // btnSetColor
            // 
            this.btnSetColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetColor.Location = new System.Drawing.Point(192, 220);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(91, 34);
            this.btnSetColor.TabIndex = 2;
            this.btnSetColor.Text = "Done";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(12, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 21);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(766, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(114, 247);
            this.colorPanel.TabIndex = 4;
            // 
            // colorGrid
            // 
            this.colorGrid.AutoAddColors = false;
            this.colorGrid.EditMode = Cyotek.Windows.Forms.ColorEditingMode.None;
            this.colorGrid.Location = new System.Drawing.Point(513, 12);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Palette = Cyotek.Windows.Forms.ColorPalette.Standard256;
            this.colorGrid.ShowCustomColors = false;
            this.colorGrid.Size = new System.Drawing.Size(247, 247);
            this.colorGrid.TabIndex = 5;
            // 
            // ColorPicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(886, 263);
            this.Controls.Add(this.colorGrid);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.colorEditor);
            this.Controls.Add(this.colorWheel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ColorPicker";
            this.ShowIcon = false;
            this.Text = "Choose Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cyotek.Windows.Forms.ColorWheel colorWheel;
        private Cyotek.Windows.Forms.ColorEditorManager colorEditorManager;
        private Cyotek.Windows.Forms.ColorEditor colorEditor;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel colorPanel;
        private Cyotek.Windows.Forms.ColorGrid colorGrid;
    }
}