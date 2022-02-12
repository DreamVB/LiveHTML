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
    public partial class frmFonts : Form
    {
        public frmFonts()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 0;
            Close();
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            if (lstFonts.SelectedIndex == -1)
                return;

            string sVal = (string)lstFonts.Items[lstFonts.SelectedIndex];
            utils.ButtonPress = 1;

            if (sVal.IndexOf(' ') > 0)
            {
                sVal = "\"" + sVal + "\"";
            }

            utils.RetStr = sVal;
            Close();
        }

        private void frmFonts_Load(object sender, EventArgs e)
        {
            foreach (FontFamily ff in System.Drawing.FontFamily.Families)
            {
                lstFonts.Items.Add(ff.Name);
            }
        }
    }
}
