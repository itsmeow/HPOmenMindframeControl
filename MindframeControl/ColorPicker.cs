using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindframeControl
{
    public partial class ColorPicker : Form
    {
        public Color color;
        private MainControl parent;

        public ColorPicker(Color colorIn)
        {
            InitializeComponent();
            this.color = colorIn;
            this.colorEditorManager.Color = colorIn;
            this.colorPanel.BackColor = colorIn;
            this.parent = null;
        }

        public ColorPicker(MainControl parentIn, Color colorIn)
        {
            InitializeComponent();
            this.parent = parentIn;
            this.color = colorIn;
            this.colorEditorManager.Color = colorIn;
            this.colorPanel.BackColor = colorIn;
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            color = colorEditorManager.Color;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void colorEditorManager_ColorChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = colorEditorManager.Color;
            if (parent != null)
            {
                await parent.setStaticColor(colorEditorManager.Color);
            }
        }
    }
}
