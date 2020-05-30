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
    public partial class ColorList : Form
    {
        private List<Color> startingColors;
        public List<Color> colors;

        public ColorList()
        {
            InitializeComponent();
        }

        public ColorList(List<Color> colors)
        {
            InitializeComponent();
            startingColors = colors;
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Add(new ColorListEntry(this, Color.White));
        }

        private void ColorList_Load(object sender, EventArgs e)
        {
            if (startingColors == null)
            {
                startingColors = new List<Color>();
                startingColors.Add(Color.White);
            }
            foreach(Color color in startingColors)
            {
                flowPanel.Controls.Add(new ColorListEntry(this, color));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            colors = new List<Color>();
            foreach(ColorListEntry entry in flowPanel.Controls)
            {
                colors.Add(entry.color);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            colors = startingColors;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
