using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindframeControl
{
    public partial class ColorListEntry : UserControl
    {
        private ColorList parent;
        public Color color;

        public ColorListEntry(ColorList parentIn, Color colorIn)
        {
            InitializeComponent();
            this.parent = parentIn;
            this.color = colorIn;
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker(color);
            DialogResult result = picker.ShowDialog();
            if(result == DialogResult.OK)
            {
                color = picker.color;
                colorDisplayPanel.BackColor = picker.color;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (parent.flowPanel.Controls.Count > 1)
            {
                parent.flowPanel.Controls.Remove(this);
            }
        }

        private void ColorListEntry_Load(object sender, EventArgs e)
        {
            colorDisplayPanel.BackColor = color;
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            int index = parent.flowPanel.Controls.IndexOf(this);
            if (parent.flowPanel.Controls.Count > 1 && index != parent.flowPanel.Controls.Count)
            {
                parent.flowPanel.Controls.Remove(this);
                parent.flowPanel.Controls.Add(this);
            }
        }
    }
}
