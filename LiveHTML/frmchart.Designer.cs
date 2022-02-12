namespace LiveHTML
{
    partial class frmchart
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
            this.lstPx = new System.Windows.Forms.ListBox();
            this.lstRem = new System.Windows.Forms.ListBox();
            this.lblPixel = new System.Windows.Forms.Label();
            this.lblRem = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.pTextCanvas = new System.Windows.Forms.Panel();
            this.cmdInsert1 = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdInsert2 = new System.Windows.Forms.Button();
            this.pTextCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPx
            // 
            this.lstPx.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPx.FormattingEnabled = true;
            this.lstPx.ItemHeight = 25;
            this.lstPx.Location = new System.Drawing.Point(29, 67);
            this.lstPx.Name = "lstPx";
            this.lstPx.Size = new System.Drawing.Size(154, 254);
            this.lstPx.TabIndex = 0;
            this.lstPx.SelectedIndexChanged += new System.EventHandler(this.lstPx_SelectedIndexChanged);
            // 
            // lstRem
            // 
            this.lstRem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRem.FormattingEnabled = true;
            this.lstRem.ItemHeight = 25;
            this.lstRem.Location = new System.Drawing.Point(200, 67);
            this.lstRem.Name = "lstRem";
            this.lstRem.Size = new System.Drawing.Size(231, 254);
            this.lstRem.TabIndex = 1;
            this.lstRem.SelectedIndexChanged += new System.EventHandler(this.lstRem_SelectedIndexChanged);
            // 
            // lblPixel
            // 
            this.lblPixel.AutoSize = true;
            this.lblPixel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPixel.Location = new System.Drawing.Point(29, 19);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(104, 38);
            this.lblPixel.TabIndex = 2;
            this.lblPixel.Text = "Pixel";
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(200, 19);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(175, 38);
            this.lblRem.TabIndex = 3;
            this.lblRem.Text = "Rem/Em";
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSample.Location = new System.Drawing.Point(175, 134);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(68, 18);
            this.lblSample.TabIndex = 4;
            this.lblSample.Text = "Sample";
            // 
            // pTextCanvas
            // 
            this.pTextCanvas.Controls.Add(this.lblSample);
            this.pTextCanvas.Location = new System.Drawing.Point(459, 31);
            this.pTextCanvas.Name = "pTextCanvas";
            this.pTextCanvas.Size = new System.Drawing.Size(404, 289);
            this.pTextCanvas.TabIndex = 5;
            // 
            // cmdInsert1
            // 
            this.cmdInsert1.Location = new System.Drawing.Point(24, 327);
            this.cmdInsert1.Name = "cmdInsert1";
            this.cmdInsert1.Size = new System.Drawing.Size(159, 41);
            this.cmdInsert1.TabIndex = 6;
            this.cmdInsert1.Text = "Insert";
            this.cmdInsert1.UseVisualStyleBackColor = true;
            this.cmdInsert1.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(769, 327);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(94, 41);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdInsert2
            // 
            this.cmdInsert2.Location = new System.Drawing.Point(200, 327);
            this.cmdInsert2.Name = "cmdInsert2";
            this.cmdInsert2.Size = new System.Drawing.Size(231, 41);
            this.cmdInsert2.TabIndex = 8;
            this.cmdInsert2.Text = "Insert";
            this.cmdInsert2.UseVisualStyleBackColor = true;
            this.cmdInsert2.Click += new System.EventHandler(this.cmdInsert2_Click);
            // 
            // frmchart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 384);
            this.Controls.Add(this.cmdInsert2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdInsert1);
            this.Controls.Add(this.pTextCanvas);
            this.Controls.Add(this.lblRem);
            this.Controls.Add(this.lblPixel);
            this.Controls.Add(this.lstRem);
            this.Controls.Add(this.lstPx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmchart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Size Chart";
            this.Load += new System.EventHandler(this.frmchart_Load);
            this.pTextCanvas.ResumeLayout(false);
            this.pTextCanvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPx;
        private System.Windows.Forms.ListBox lstRem;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.Label lblRem;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Panel pTextCanvas;
        private System.Windows.Forms.Button cmdInsert1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdInsert2;
    }
}