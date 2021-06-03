namespace Adição
{
    partial class frm_Acerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Acerto));
            this.btnAcertoOK = new System.Windows.Forms.Button();
            this.lblAcertoOK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcertoOK
            // 
            this.btnAcertoOK.Location = new System.Drawing.Point(123, 38);
            this.btnAcertoOK.Name = "btnAcertoOK";
            this.btnAcertoOK.Size = new System.Drawing.Size(75, 23);
            this.btnAcertoOK.TabIndex = 0;
            this.btnAcertoOK.Text = "OK";
            this.btnAcertoOK.UseVisualStyleBackColor = true;
            this.btnAcertoOK.Click += new System.EventHandler(this.btnAcertoOK_Click);
            // 
            // lblAcertoOK
            // 
            this.lblAcertoOK.AutoSize = true;
            this.lblAcertoOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertoOK.Location = new System.Drawing.Point(73, 9);
            this.lblAcertoOK.Name = "lblAcertoOK";
            this.lblAcertoOK.Size = new System.Drawing.Size(213, 13);
            this.lblAcertoOK.TabIndex = 1;
            this.lblAcertoOK.Text = "Parabéns!!!! Vc acertou o resultado!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Acerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 74);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAcertoOK);
            this.Controls.Add(this.btnAcertoOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Acerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acertou!!!!!";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcertoOK;
        private System.Windows.Forms.Label lblAcertoOK;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}