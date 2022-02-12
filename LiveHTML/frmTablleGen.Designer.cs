namespace LiveHTML
{
    partial class frmTablleGen
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
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColunms = new System.Windows.Forms.TextBox();
            this.lblColunms = new System.Windows.Forms.Label();
            this.chkBorder = new System.Windows.Forms.CheckBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.cmdGen = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(27, 40);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(53, 20);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(86, 37);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 26);
            this.txtRows.TabIndex = 1;
            this.txtRows.Text = "3";
            this.txtRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRows_KeyPress);
            // 
            // txtColunms
            // 
            this.txtColunms.Location = new System.Drawing.Point(299, 40);
            this.txtColunms.Name = "txtColunms";
            this.txtColunms.Size = new System.Drawing.Size(90, 26);
            this.txtColunms.TabIndex = 3;
            this.txtColunms.Text = "3";
            this.txtColunms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColunms_KeyPress);
            // 
            // lblColunms
            // 
            this.lblColunms.AutoSize = true;
            this.lblColunms.Location = new System.Drawing.Point(216, 43);
            this.lblColunms.Name = "lblColunms";
            this.lblColunms.Size = new System.Drawing.Size(71, 20);
            this.lblColunms.TabIndex = 2;
            this.lblColunms.Text = "Colunms";
            // 
            // chkBorder
            // 
            this.chkBorder.AutoSize = true;
            this.chkBorder.Location = new System.Drawing.Point(414, 43);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.Size = new System.Drawing.Size(83, 24);
            this.chkBorder.TabIndex = 4;
            this.chkBorder.Text = "Border";
            this.chkBorder.UseVisualStyleBackColor = true;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(30, 85);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTable.Size = new System.Drawing.Size(466, 224);
            this.txtTable.TabIndex = 5;
            // 
            // cmdGen
            // 
            this.cmdGen.Location = new System.Drawing.Point(31, 327);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(108, 40);
            this.cmdGen.TabIndex = 6;
            this.cmdGen.Text = "Generate";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(145, 327);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(108, 40);
            this.cmdInsert.TabIndex = 7;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(388, 327);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(108, 40);
            this.cmdClose.TabIndex = 8;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmTablleGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 388);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdGen);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.chkBorder);
            this.Controls.Add(this.txtColunms);
            this.Controls.Add(this.lblColunms);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTablleGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColunms;
        private System.Windows.Forms.Label lblColunms;
        private System.Windows.Forms.CheckBox chkBorder;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdClose;
    }
}