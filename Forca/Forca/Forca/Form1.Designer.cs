namespace Forca
{
    partial class frmPrincipal
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
            this.pnParametros = new System.Windows.Forms.Panel();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.txtPalavraSecreta = new System.Windows.Forms.TextBox();
            this.lblTitPalSecreta = new System.Windows.Forms.Label();
            this.btnMostraOcultaPalavra = new System.Windows.Forms.Button();
            this.lblPalavraSecreta = new System.Windows.Forms.Label();
            this.pnParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnParametros
            // 
            this.pnParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnParametros.Controls.Add(this.lblPalavraSecreta);
            this.pnParametros.Controls.Add(this.btnMostraOcultaPalavra);
            this.pnParametros.Controls.Add(this.lblTitPalSecreta);
            this.pnParametros.Controls.Add(this.txtPalavraSecreta);
            this.pnParametros.Location = new System.Drawing.Point(1, 1);
            this.pnParametros.Name = "pnParametros";
            this.pnParametros.Size = new System.Drawing.Size(368, 111);
            this.pnParametros.TabIndex = 0;
            // 
            // pnJogo
            // 
            this.pnJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnJogo.Location = new System.Drawing.Point(1, 118);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(368, 111);
            this.pnJogo.TabIndex = 1;
            // 
            // txtPalavraSecreta
            // 
            this.txtPalavraSecreta.Location = new System.Drawing.Point(22, 35);
            this.txtPalavraSecreta.MaxLength = 10;
            this.txtPalavraSecreta.Name = "txtPalavraSecreta";
            this.txtPalavraSecreta.PasswordChar = '#';
            this.txtPalavraSecreta.Size = new System.Drawing.Size(237, 20);
            this.txtPalavraSecreta.TabIndex = 0;
            // 
            // lblTitPalSecreta
            // 
            this.lblTitPalSecreta.AutoSize = true;
            this.lblTitPalSecreta.Location = new System.Drawing.Point(22, 12);
            this.lblTitPalSecreta.Name = "lblTitPalSecreta";
            this.lblTitPalSecreta.Size = new System.Drawing.Size(237, 13);
            this.lblTitPalSecreta.TabIndex = 1;
            this.lblTitPalSecreta.Text = "Digite a palavra a ser descoberta (máx. 10 letras)";
            // 
            // btnMostraOcultaPalavra
            // 
            this.btnMostraOcultaPalavra.Location = new System.Drawing.Point(266, 31);
            this.btnMostraOcultaPalavra.Name = "btnMostraOcultaPalavra";
            this.btnMostraOcultaPalavra.Size = new System.Drawing.Size(75, 23);
            this.btnMostraOcultaPalavra.TabIndex = 2;
            this.btnMostraOcultaPalavra.Text = "Mostrar";
            this.btnMostraOcultaPalavra.UseVisualStyleBackColor = true;
            this.btnMostraOcultaPalavra.Click += new System.EventHandler(this.btnMostraOcultaPalavra_Click);
            // 
            // lblPalavraSecreta
            // 
            this.lblPalavraSecreta.AutoSize = true;
            this.lblPalavraSecreta.Location = new System.Drawing.Point(22, 62);
            this.lblPalavraSecreta.Name = "lblPalavraSecreta";
            this.lblPalavraSecreta.Size = new System.Drawing.Size(90, 13);
            this.lblPalavraSecreta.TabIndex = 3;
            this.lblPalavraSecreta.Text = "lblPalavraSecreta";
            this.lblPalavraSecreta.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 264);
            this.Controls.Add(this.pnJogo);
            this.Controls.Add(this.pnParametros);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Jogo da Forca";
            this.pnParametros.ResumeLayout(false);
            this.pnParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnParametros;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Label lblTitPalSecreta;
        private System.Windows.Forms.TextBox txtPalavraSecreta;
        private System.Windows.Forms.Button btnMostraOcultaPalavra;
        private System.Windows.Forms.Label lblPalavraSecreta;
    }
}

