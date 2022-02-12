namespace LiveHTML
{
    partial class frmRndText
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
            this.lblWords = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.cmdGen = new System.Windows.Forms.Button();
            this.txtRandText = new System.Windows.Forms.TextBox();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(18, 22);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(133, 20);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "Number of Words";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(165, 19);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 26);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "50";
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // cmdGen
            // 
            this.cmdGen.Location = new System.Drawing.Point(305, 15);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(357, 34);
            this.cmdGen.TabIndex = 2;
            this.cmdGen.Text = "Create Random Text";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // txtRandText
            // 
            this.txtRandText.Location = new System.Drawing.Point(26, 71);
            this.txtRandText.Multiline = true;
            this.txtRandText.Name = "txtRandText";
            this.txtRandText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRandText.Size = new System.Drawing.Size(647, 312);
            this.txtRandText.TabIndex = 3;
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(22, 401);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(106, 39);
            this.cmdInsert.TabIndex = 4;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(567, 401);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(106, 39);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmRndText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 461);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.txtRandText);
            this.Controls.Add(this.cmdGen);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRndText";
            this.Text = "Lorem Ipsum";
            this.Load += new System.EventHandler(this.frmRndText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.TextBox txtRandText;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdClose;
    }
}