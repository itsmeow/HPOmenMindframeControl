namespace MindframeControl
{
    partial class ColorListEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDisplayPanel = new System.Windows.Forms.Panel();
            this.btnEditColor = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDisplayPanel
            // 
            this.colorDisplayPanel.BackColor = System.Drawing.Color.Black;
            this.colorDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorDisplayPanel.Location = new System.Drawing.Point(3, 3);
            this.colorDisplayPanel.Name = "colorDisplayPanel";
            this.colorDisplayPanel.Size = new System.Drawing.Size(49, 30);
            this.colorDisplayPanel.TabIndex = 0;
            // 
            // btnEditColor
            // 
            this.btnEditColor.Location = new System.Drawing.Point(58, 6);
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(75, 23);
            this.btnEditColor.TabIndex = 1;
            this.btnEditColor.Text = "Edit Color";
            this.btnEditColor.UseVisualStyleBackColor = true;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(236, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Image = global::MindframeControl.Properties.Resources.downarrow;
            this.btnBottom.Location = new System.Drawing.Point(202, 3);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(28, 28);
            this.btnBottom.TabIndex = 3;
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // ColorListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditColor);
            this.Controls.Add(this.colorDisplayPanel);
            this.Name = "ColorListEntry";
            this.Size = new System.Drawing.Size(267, 38);
            this.Load += new System.EventHandler(this.ColorListEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel colorDisplayPanel;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBottom;
    }
}
