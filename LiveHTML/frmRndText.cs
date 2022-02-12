using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LiveHTML
{
    public partial class frmRndText : Form
    {
        public frmRndText()
        {
            InitializeComponent();
        }

        private List<string> Words = new List<string>();
        private Random rnd = new Random();

        private void MakeRandomText(int words)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Lorem ipsum dolor sit amet, consectetur ");

            for (int x = 1; x <= words; x++)
            {
                int n = rnd.Next(0, Words.Count - 1);

                sb.Append(Words[n] + " ");
            }
            txtRandText.Text = sb.ToString().TrimEnd();
            sb.Clear();
        }

        private void PrepText()
        {
            string lzFile = utils.FixPath(Environment.CurrentDirectory) + "lorem.dat";
            try
            {
                string[] data = File.ReadAllText(lzFile).Split(' ');

                foreach (string S in data)
                {
                    string sLine = S.Trim();
                    if (sLine.Length > 1)
                    {
                        Words.Add(sLine);
                    }
                }
                Array.Clear(data, 0, data.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRndText_Load(object sender, EventArgs e)
        {
            PrepText();
        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            try
            {
                MakeRandomText(int.Parse(txtCount.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 1;
            utils.RetStr = txtRandText.Text;
            Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            utils.ButtonPress = 0;
            Close();
        }
    }
}
