namespace Adição
{
    partial class frm_Erro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Erro));
            this.btnErroOK = new System.Windows.Forms.Button();
            this.lblErroOK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnErroOK
            // 
            this.btnErroOK.Location = new System.Drawing.Point(123, 38);
            this.btnErroOK.Name = "btnErroOK";
            this.btnErroOK.Size = new System.Drawing.Size(75, 23);
            this.btnErroOK.TabIndex = 0;
            this.btnErroOK.Text = "OK";
            this.btnErroOK.UseVisualStyleBackColor = true;
            this.btnErroOK.Click += new System.EventHandler(this.btnErroOK_Click);
            // 
            // lblErroOK
            // 
            this.lblErroOK.AutoSize = true;
            this.lblErroOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroOK.Location = new System.Drawing.Point(98, 9);
            this.lblErroOK.Name = "lblErroOK";
            this.lblErroOK.Size = new System.Drawing.Size(165, 13);
            this.lblErroOK.TabIndex = 2;
            this.lblErroOK.Text = "Errado!!! Tente Novamente!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Erro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 74);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErroOK);
            this.Controls.Add(this.btnErroOK);
            this.Name = "frm_Erro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erro!!!";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnErroOK;
        private System.Windows.Forms.Label lblErroOK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}