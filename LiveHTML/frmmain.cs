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
using System.Diagnostics;

namespace LiveHTML
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private const string dlg_filter = "HTML Files(*.html)|*.html|HTM Files(*.htm)|*.htm|Text Files(*.txt)|*.txt";

        private string SourceFile { get; set; }
        private string HtmlTagsPath { get; set; }
        private string CSSTagPath { get; set; }
        private string HTMLCharsPath { get; set; }
        private List<string> TagData = new List<string>();

        private void VisibleMenus()
        {
            bool n = sTab1.TabPages.Count > 0;
            mnuSave.Visible = n;
            mnuSaveAs.Visible = n;
            mnuExtra.Visible = n;
            mnuEdit.Visible = n;
            splitContainer1.Visible = n;
        }

        private void ErrorEvent(Exception ex)
        {
            MessageBox.Show(ex.Message, Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private RichTextBox GetCurrentDoc()
        {
            return (RichTextBox)sTab1.SelectedTab.Controls["Body"];
        }

        private void NewTab(string Filename = "", string TextSource = "")
        {
            TabPage tp = new TabPage();
            RichTextBox rb = new RichTextBox();

            rb.Dock = DockStyle.Fill;
            rb.Text = string.Empty;
            rb.Name = "Body";
            rb.Text = TextSource;
            rb.AcceptsTab = true;
            rb.Multiline = true;
            rb.WordWrap = false;
            rb.Font = new Font("Consolas", 11);
            rb.ScrollBars = RichTextBoxScrollBars.Both;
            rb.Tag = Filename;
            rb.ContextMenuStrip = mnuEditPopup;
            rb.TextChanged += Text_Update;
            rb.KeyPress += KeyPress;
            tp.Controls.Add(rb);
            tp.Text = GetFilename(Filename);

            sTab1.TabPages.Add(tp);
        }

        private void Text_Update(object sender, EventArgs e)
        {
            mnuSave_Click(sender, e);
            wView.Navigate((string)GetCurrentDoc().Tag);
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox rb1 = GetCurrentDoc();

            if (e.KeyChar == '\t')
            {
                rb1.SelectedText = new string(' ', 4);
                e.Handled = true;
            }
            if (e.KeyChar == '"')
            {
                rb1.SelectedText = "\"";
                rb1.SelectionStart--;
            }
            if (e.KeyChar == '(')
            {
                rb1.SelectedText = ")";
                rb1.SelectionStart--;
            }
            if (e.KeyChar == '<')
            {
                rb1.SelectedText = ">";
                rb1.SelectionStart--;
            }
            if (e.KeyChar == '{')
            {
                rb1.SelectedText = "}";
                rb1.SelectionStart--;
            }
            if (e.KeyChar == '[')
            {
                rb1.SelectedText = "]";
                rb1.SelectionStart--;
            }
            if (e.KeyChar == '\r')
            {
                try
                {
                    //Get line index
                    int lnIdx = rb1.GetLineFromCharIndex(rb1.SelectionStart);
                    //Get the line as a string
                    string Line = rb1.Lines[lnIdx - 1];
                    //Get line ident size
                    int l = GetIdentSize(Line);
                    //Add ident space
                    rb1.SelectedText = new string(' ', l);
                }
                catch { }
            }
        }

        private string GetFilename(string Filename)
        {
            int pos = Filename.LastIndexOf("\\");

            if (pos > 0)
            {
                return Filename.Substring(pos + 1);
            }
            return Filename;
        }

        private string GetOpenDlgFilename(string Title = "Open")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = Title;
            ofd.Filter = dlg_filter;
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                return ofd.FileName;
            }
            ofd.Dispose();
            return string.Empty;
        }

        private string GetSaveDlgFilename(string Title="Save As", string defFilename="")
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = Title;
            sfd.Filter = dlg_filter;
            sfd.FilterIndex = 1;
            sfd.FileName = defFilename;
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                return sfd.FileName;
            }
            sfd.Dispose();
            return string.Empty;
        }

        private Color GetColorFromDlg()
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog().Equals(DialogResult.OK))
            {
                return cd.Color;
            }
            return Color.Empty;
        }

        private void LoadTags(string Filename, int op = 0)
        {
            string sLine = string.Empty;
            int pos = 0;

            lstTags.Items.Clear();
            TagData.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(Filename))
                {
                    while (!sr.EndOfStream)
                    {
                        sLine = sr.ReadLine().Trim();
                        if (sLine.Length > 0)
                        {
                            if (op == 0 || op == 1)
                            {
                                pos = sLine.LastIndexOf('\t');

                                if (pos > 0)
                                {
                                    TagData.Add(sLine);
                                    if (op == 0)
                                    {
                                        lstTags.Items.Add(sLine.Remove(pos).TrimStart('<').TrimEnd('>'));
                                    }
                                    else
                                    {
                                        lstTags.Items.Add(sLine.Remove(pos));
                                    }
                                }
                            }

                            if (op == 2)
                            {
                                TagData.Add(sLine);
                                lstTags.Items.Add(sLine);
                            }

                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorEvent(ex);
            }
        }

        private Int32 GetIdentSize(string Line)
        {
            Int32 x = 0;

            while (x < Line.Length)
            {
                if (!char.IsWhiteSpace(Line[x]))
                {
                    break;
                }
                x++;
            }
            return x;
        }

        private void WriteHTML()
        {
            try
            {
                StreamWriter sw = new StreamWriter("index.html");
               // sw.Write(rb1.Text);
                sw.Close();
            }
            catch
            {
                
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {

            string lzFile = GetSaveDlgFilename("New","NewPage.html");

            if (lzFile.Length > 0)
            {
                NewTab(lzFile, Properties.Resources.NewPage);
                //Write the data to a file.
                try
                {
                    File.WriteAllText(lzFile, GetCurrentDoc().Text);
                    wView.Navigate(lzFile);
                    VisibleMenus();
                }
                catch (Exception ex)
                {
                    ErrorEvent(ex);
                }
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            string AppPath = utils.FixPath(Environment.CurrentDirectory);
            mnuAbout.Text = "&About " + Text + "...";
            SourceFile = AppPath + "data\\index.html";
            HtmlTagsPath = AppPath + "data\\html.dat";
            CSSTagPath = AppPath + "data\\css.dat";
            HTMLCharsPath = AppPath + "data\\chars.dat";
            cboOp.SelectedIndex = 0;
            wView.Navigate("about:blank");
            VisibleMenus();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            try
            {
                GetCurrentDoc().SelectedText = Clipboard.GetText();
            }
            catch(Exception ex)
            {
                ErrorEvent(ex);
            }
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectAll();
            GetCurrentDoc().Focus();
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
           if (GetCurrentDoc().CanUndo)
           {
               GetCurrentDoc().Undo();
           }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectedText = string.Empty;
            GetCurrentDoc().Focus();
        }

        private void lstTags_DoubleClick(object sender, EventArgs e)
        {
            string sInsert = TagData[lstTags.SelectedIndex];

            if (cboOp.SelectedIndex == 0)
            {
                sInsert = sInsert.Replace('\t'.ToString(), GetCurrentDoc().SelectedText);
            }

            if (cboOp.SelectedIndex == 1)
            {
                sInsert = sInsert.Split('\t')[1];
            }

            GetCurrentDoc().SelectedText = sInsert;
            GetCurrentDoc().Focus();
        }

        private void lstTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            int idx = 0;

            if (e.KeyChar == '\r')
            {
                lstTags_DoubleClick(sender, e);
                return;
            }

            foreach (string S in lstTags.Items)
            {
                if (char.ToUpper(S[0]) == (char.ToUpper(e.KeyChar)))
                {
                    break;
                }
                idx++;
            }

            if (idx < 0 || idx > (lstTags.Items.Count - 1))
            {
                return;
            }

            lstTags.SelectedIndex = idx;
        }

        private void mnuColorPicker_Click(object sender, EventArgs e)
        {
            Color c = GetColorFromDlg();

            if (c != Color.Empty)
            {
                GetCurrentDoc().SelectedText = System.Drawing.ColorTranslator.ToHtml(c);
                GetCurrentDoc().Focus();
            }
        }

        private void mnuNewWindow_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = utils.FixPath(Environment.CurrentDirectory) + "LiveHTML.exe";
            p.Start();
        }

        private void mnuHtmlRef_Click(object sender, EventArgs e)
        {
            utils.StartWeb("https://developer.mozilla.org/en-US/docs/Web/HTML/Reference");
        }

        private void cboOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOp.SelectedIndex == 0)
            {
                LoadTags(HtmlTagsPath);
            }
            if (cboOp.SelectedIndex == 1)
            {
                LoadTags(HTMLCharsPath, 1);
            }
            if (cboOp.SelectedIndex == 2)
            {
                LoadTags(CSSTagPath, 2);
            }
        }

        private void mnuInsertTag_Click(object sender, EventArgs e)
        {
            if(lstTags.SelectedIndex != -1)
            lstTags_DoubleClick(sender, e);
        }

        private void mnuUndo1_Click(object sender, EventArgs e)
        {
            mnuUndo_Click(sender, e);
        }

        private void mnuCut1_Click(object sender, EventArgs e)
        {
            mnuCut_Click(sender, e);
        }

        private void mnuCopy1_Click(object sender, EventArgs e)
        {
            mnuCopy_Click(sender, e);
        }

        private void mnuPaste1_Click(object sender, EventArgs e)
        {
            mnuPaste_Click(sender, e);
        }

        private void mnuDelete1_Click(object sender, EventArgs e)
        {
            mnuDelete_Click(sender, e);
        }

        private void mnuSelectAll1_Click(object sender, EventArgs e)
        {
            mnuSelectAll_Click(sender, e);
        }

        private void mnuCsscomment_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectedText = " /* " + GetCurrentDoc().SelectedText + " */";
        }

        private void mnuHtmlComment_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectedText = "<!--" + GetCurrentDoc().SelectedText + "-->";
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            frmFonts frm = new frmFonts();

            utils.ButtonPress = 0;

            frm.ShowDialog();

            if (utils.ButtonPress == 1)
            {
                GetCurrentDoc().SelectedText = utils.RetStr;
            }

            GetCurrentDoc().Focus();
        }

        private void mnuSizeChart_Click(object sender, EventArgs e)
        {
            frmchart frm = new frmchart();

            utils.ButtonPress = 0;
            frm.ShowDialog();

            if (utils.ButtonPress == 1)
            {
                GetCurrentDoc().SelectedText = utils.RetStr;
            }
        }

        private void mnuRandText_Click(object sender, EventArgs e)
        {
            frmRndText frm = new frmRndText();
            utils.ButtonPress = 0;
            frm.ShowDialog();
            if (utils.ButtonPress == 1)
            {
                GetCurrentDoc().SelectedText = utils.RetStr;
                GetCurrentDoc().Focus();
            }
        }

        private void mnuSearchGoogle_Click(object sender, EventArgs e)
        {

        }

        private void mnuSearchGoogle1_Click(object sender, EventArgs e)
        {
            if (GetCurrentDoc().SelectionLength > 0)
            {
                utils.StartWeb("https://www.google.com/search?q=" + GetCurrentDoc().SelectedText);
            }
        }

        private void mnuTableGen_Click(object sender, EventArgs e)
        {
            frmTablleGen frm = new frmTablleGen();
            utils.ButtonPress = 0;
            frm.ShowDialog();

            if (utils.ButtonPress == 1)
            {
                GetCurrentDoc().SelectedText = utils.RetStr;
                GetCurrentDoc().Focus();
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Save doc
            try
            {
                GetCurrentDoc().SaveFile((string)GetCurrentDoc().Tag, RichTextBoxStreamType.PlainText);
            }
            catch(Exception ex)
            {
                ErrorEvent(ex);
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            string lzFile = GetSaveDlgFilename("",sTab1.SelectedTab.Text);

            if (lzFile.Length > 0)
            {
                GetCurrentDoc().Tag = lzFile;
                GetCurrentDoc().SaveFile((string)GetCurrentDoc().Tag, RichTextBoxStreamType.PlainText);
                sTab1.SelectedTab.Text = GetFilename(lzFile);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            string lzFile = GetOpenDlgFilename();

            if (lzFile.Length > 0)
            {
                NewTab(lzFile, File.ReadAllText(lzFile));
                wView.Navigate(lzFile);
                GetCurrentDoc().Focus();
                VisibleMenus();
            }
        }

        private void mnuHtmlTut_Click(object sender, EventArgs e)
        {
            utils.StartWeb("https://www.w3schools.com/html/");
        }

        private void mnuCssTut_Click(object sender, EventArgs e)
        {
            utils.StartWeb("https://www.w3schools.com/css/");
        }

        private void mnuCloseTab_Click(object sender, EventArgs e)
        {

            if (sTab1.TabPages.Count == 0)
                return;

            DialogResult dr=MessageBox.Show("Are you sure you want to close this tab.", Text,
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                sTab1.TabPages.Remove(sTab1.SelectedTab);
                VisibleMenus();
            }

        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            if (sTab1.TabPages.Count == 0)
                return;
            wView.Navigate((string)GetCurrentDoc().Tag);
        }

        private void mnuTab2Spc_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().Text = GetCurrentDoc().Text.Replace("\t", "    ");
        }

        private void mnuSpc2Tabs_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().Text = GetCurrentDoc().Text.Replace("    ", "\t");
        }

        private void mnulCase_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectedText = GetCurrentDoc().SelectedText.ToLower();
        }

        private void mnuAppendCut_Click(object sender, EventArgs e)
        {
            //Get clipbard text
            try
            {
                string S0 = Clipboard.GetText();
                Clipboard.SetText(S0 + GetCurrentDoc().SelectedText);
                GetCurrentDoc().SelectedText = "";
                GetCurrentDoc().Focus();
            }
            catch
            {

            }
        }

        private void mnuAppendCopy_Click(object sender, EventArgs e)
        {
            //Get clipbard text
            try
            {
                string S0 = Clipboard.GetText();
                Clipboard.SetText(S0 + GetCurrentDoc().SelectedText);
            }
            catch
            {

            }
        }

        private void mnuClrClip_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void mnuUcase_Click(object sender, EventArgs e)
        {
            GetCurrentDoc().SelectedText = GetCurrentDoc().SelectedText.ToUpper();
        }

        private void mnuReadme_Click(object sender, EventArgs e)
        {
            utils.StartWeb("readme.txt");
        }
    }
}
