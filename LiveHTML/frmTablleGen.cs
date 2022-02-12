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
    public partial class frmTablleGen : Form
    {
        public frmTablleGen()
        {
            InitializeComponent();
        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();

            try
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtColunms.Text);
                //

                if (chkBorder.Checked)
                {
                    sb.AppendLine("<table border=\"" + "1" + "\"" +">");
                }
                else
                {
                    sb.AppendLine("<table>");
                }
                sb.AppendLine("<tbody>");

                for (int x = 1; x <= rows; x++)
                {
                    sb.AppendLine("<tr>");
                    for (int y = 1; y <= cols; y++)
                    {
                        sb.AppendLine("<td>&nbsp;</td>");
                    }
                    sb.AppendLine("</td>");
                }

                sb.AppendLine("</tbody>");
                sb.AppendLine("</table>");
                
                txtTable.Text = sb.ToString().Trim();
                txtTable.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColunms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 0;
            Close();
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 1;
            utils.RetStr = txtTable.Text;
            Close();
        }
    }
}
