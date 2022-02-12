using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveHTML
{
    public partial class frmchart : Form
    {
        public frmchart()
        {
            InitializeComponent();
        }

        private void ShowExample(int Index)
        {
            lblSample.Font = new Font(lblSample.Font.Name, Index);
            //Center the labal hoz and vert
            lblSample.Left = (pTextCanvas.Width - lblSample.Width) / 2;
            lblSample.Top = (pTextCanvas.Height - lblSample.Height) / 2;
        }

        private void frmchart_Load(object sender, EventArgs e)
        {
            double rem = 0;
            double b = 16;

            for (int x = 8; x <= 48; x++)
            {
                rem = Convert.ToDouble(x) / b;

                lstPx.Items.Add(x.ToString() + "px");
                lstRem.Items.Add(rem.ToString() + "em");
            }
            lstPx.SelectedIndex = 8;
        }

        private void lstPx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstRem.SelectedIndex = lstPx.SelectedIndex;
            ShowExample(lstPx.SelectedIndex + 8);
        }

        private void lstRem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPx.SelectedIndex = lstRem.SelectedIndex;
            ShowExample(lstRem.SelectedIndex + 8);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 0;
            Close();
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 1;
            utils.RetStr = (string)lstPx.Items[lstPx.SelectedIndex];
            Close();
        }

        private void cmdInsert2_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 1;
            utils.RetStr = (string)lstRem.Items[lstRem.SelectedIndex];
            Close();
        }
    }
}
