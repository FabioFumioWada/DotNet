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
            this.lblPalavraSecreta = new System.Windows.Forms.Label();
            this.btnMostraOcultaPalavra = new System.Windows.Forms.Button();
            this.lblTitPalSecreta = new System.Windows.Forms.Label();
            this.txtPalavraSecreta = new System.Windows.Forms.TextBox();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.lblTitJogoPalSecreta = new System.Windows.Forms.Label();
            this.txtPalavraPesq = new System.Windows.Forms.TextBox();
            this.txtLetra01 = new System.Windows.Forms.TextBox();
            this.txtLetra02 = new System.Windows.Forms.TextBox();
            this.txtLetra03 = new System.Windows.Forms.TextBox();
            this.txtLetra04 = new System.Windows.Forms.TextBox();
            this.txtLetra05 = new System.Windows.Forms.TextBox();
            this.txtLetra06 = new System.Windows.Forms.TextBox();
            this.txtLetra07 = new System.Windows.Forms.TextBox();
            this.txtLetra08 = new System.Windows.Forms.TextBox();
            this.txtLetra09 = new System.Windows.Forms.TextBox();
            this.txtLetra10 = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitTentativas = new System.Windows.Forms.Label();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.lblTitLetrasErradas = new System.Windows.Forms.Label();
            this.lblLetrasErradas = new System.Windows.Forms.Label();
            this.pnParametros.SuspendLayout();
            this.pnJogo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnParametros.Size = new System.Drawing.Size(368, 86);
            this.pnParametros.TabIndex = 0;
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
            // btnMostraOcultaPalavra
            // 
            this.btnMostraOcultaPalavra.Location = new System.Drawing.Point(266, 33);
            this.btnMostraOcultaPalavra.Name = "btnMostraOcultaPalavra";
            this.btnMostraOcultaPalavra.Size = new System.Drawing.Size(75, 23);
            this.btnMostraOcultaPalavra.TabIndex = 2;
            this.btnMostraOcultaPalavra.Text = "Mostrar";
            this.btnMostraOcultaPalavra.UseVisualStyleBackColor = true;
            this.btnMostraOcultaPalavra.Click += new System.EventHandler(this.btnMostraOcultaPalavra_Click);
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
            // txtPalavraSecreta
            // 
            this.txtPalavraSecreta.BackColor = System.Drawing.Color.Yellow;
            this.txtPalavraSecreta.Location = new System.Drawing.Point(25, 35);
            this.txtPalavraSecreta.MaxLength = 10;
            this.txtPalavraSecreta.Name = "txtPalavraSecreta";
            this.txtPalavraSecreta.PasswordChar = '#';
            this.txtPalavraSecreta.Size = new System.Drawing.Size(215, 20);
            this.txtPalavraSecreta.TabIndex = 0;
            this.txtPalavraSecreta.TextChanged += new System.EventHandler(this.txtPalavraSecreta_TextChanged);
            // 
            // pnJogo
            // 
            this.pnJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnJogo.Controls.Add(this.btnValidar);
            this.pnJogo.Controls.Add(this.txtLetra10);
            this.pnJogo.Controls.Add(this.txtLetra09);
            this.pnJogo.Controls.Add(this.txtLetra08);
            this.pnJogo.Controls.Add(this.txtLetra07);
            this.pnJogo.Controls.Add(this.txtLetra06);
            this.pnJogo.Controls.Add(this.txtLetra05);
            this.pnJogo.Controls.Add(this.txtLetra04);
            this.pnJogo.Controls.Add(this.txtLetra03);
            this.pnJogo.Controls.Add(this.txtLetra02);
            this.pnJogo.Controls.Add(this.txtLetra01);
            this.pnJogo.Controls.Add(this.txtPalavraPesq);
            this.pnJogo.Controls.Add(this.lblTitJogoPalSecreta);
            this.pnJogo.Location = new System.Drawing.Point(1, 93);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(368, 86);
            this.pnJogo.TabIndex = 1;
            this.pnJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnJogo_Paint);
            // 
            // lblTitJogoPalSecreta
            // 
            this.lblTitJogoPalSecreta.AutoSize = true;
            this.lblTitJogoPalSecreta.Location = new System.Drawing.Point(22, 18);
            this.lblTitJogoPalSecreta.Name = "lblTitJogoPalSecreta";
            this.lblTitJogoPalSecreta.Size = new System.Drawing.Size(152, 13);
            this.lblTitJogoPalSecreta.TabIndex = 0;
            this.lblTitJogoPalSecreta.Text = "Digite a letra a ser pesquisada:";
            // 
            // txtPalavraPesq
            // 
            this.txtPalavraPesq.BackColor = System.Drawing.Color.Yellow;
            this.txtPalavraPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavraPesq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPalavraPesq.Location = new System.Drawing.Point(181, 10);
            this.txtPalavraPesq.MaxLength = 1;
            this.txtPalavraPesq.Name = "txtPalavraPesq";
            this.txtPalavraPesq.Size = new System.Drawing.Size(25, 26);
            this.txtPalavraPesq.TabIndex = 1;
            this.txtPalavraPesq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetra01
            // 
            this.txtLetra01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra01.Location = new System.Drawing.Point(25, 45);
            this.txtLetra01.MaxLength = 1;
            this.txtLetra01.Name = "txtLetra01";
            this.txtLetra01.Size = new System.Drawing.Size(25, 26);
            this.txtLetra01.TabIndex = 2;
            this.txtLetra01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra01.Visible = false;
            // 
            // txtLetra02
            // 
            this.txtLetra02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra02.Location = new System.Drawing.Point(56, 45);
            this.txtLetra02.MaxLength = 1;
            this.txtLetra02.Name = "txtLetra02";
            this.txtLetra02.Size = new System.Drawing.Size(25, 26);
            this.txtLetra02.TabIndex = 3;
            this.txtLetra02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra02.Visible = false;
            // 
            // txtLetra03
            // 
            this.txtLetra03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra03.Location = new System.Drawing.Point(87, 45);
            this.txtLetra03.MaxLength = 1;
            this.txtLetra03.Name = "txtLetra03";
            this.txtLetra03.Size = new System.Drawing.Size(25, 26);
            this.txtLetra03.TabIndex = 4;
            this.txtLetra03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra03.Visible = false;
            // 
            // txtLetra04
            // 
            this.txtLetra04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra04.Location = new System.Drawing.Point(118, 45);
            this.txtLetra04.MaxLength = 1;
            this.txtLetra04.Name = "txtLetra04";
            this.txtLetra04.Size = new System.Drawing.Size(25, 26);
            this.txtLetra04.TabIndex = 5;
            this.txtLetra04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra04.Visible = false;
            // 
            // txtLetra05
            // 
            this.txtLetra05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra05.Location = new System.Drawing.Point(149, 45);
            this.txtLetra05.MaxLength = 1;
            this.txtLetra05.Name = "txtLetra05";
            this.txtLetra05.Size = new System.Drawing.Size(25, 26);
            this.txtLetra05.TabIndex = 6;
            this.txtLetra05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra05.Visible = false;
            // 
            // txtLetra06
            // 
            this.txtLetra06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra06.Location = new System.Drawing.Point(180, 45);
            this.txtLetra06.MaxLength = 1;
            this.txtLetra06.Name = "txtLetra06";
            this.txtLetra06.Size = new System.Drawing.Size(25, 26);
            this.txtLetra06.TabIndex = 7;
            this.txtLetra06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra06.Visible = false;
            // 
            // txtLetra07
            // 
            this.txtLetra07.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra07.Location = new System.Drawing.Point(211, 45);
            this.txtLetra07.MaxLength = 1;
            this.txtLetra07.Name = "txtLetra07";
            this.txtLetra07.Size = new System.Drawing.Size(25, 26);
            this.txtLetra07.TabIndex = 8;
            this.txtLetra07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra07.Visible = false;
            // 
            // txtLetra08
            // 
            this.txtLetra08.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra08.Location = new System.Drawing.Point(242, 45);
            this.txtLetra08.MaxLength = 1;
            this.txtLetra08.Name = "txtLetra08";
            this.txtLetra08.Size = new System.Drawing.Size(25, 26);
            this.txtLetra08.TabIndex = 9;
            this.txtLetra08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra08.Visible = false;
            // 
            // txtLetra09
            // 
            this.txtLetra09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra09.Location = new System.Drawing.Point(273, 45);
            this.txtLetra09.MaxLength = 1;
            this.txtLetra09.Name = "txtLetra09";
            this.txtLetra09.Size = new System.Drawing.Size(25, 26);
            this.txtLetra09.TabIndex = 10;
            this.txtLetra09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra09.Visible = false;
            // 
            // txtLetra10
            // 
            this.txtLetra10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra10.Location = new System.Drawing.Point(304, 45);
            this.txtLetra10.MaxLength = 1;
            this.txtLetra10.Name = "txtLetra10";
            this.txtLetra10.Size = new System.Drawing.Size(25, 26);
            this.txtLetra10.TabIndex = 11;
            this.txtLetra10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra10.Visible = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(266, 8);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 12;
            this.btnValidar.Text = "Verificar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLetrasErradas);
            this.panel1.Controls.Add(this.lblTitLetrasErradas);
            this.panel1.Controls.Add(this.lblTentativas);
            this.panel1.Controls.Add(this.lblTitTentativas);
            this.panel1.Location = new System.Drawing.Point(1, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 86);
            this.panel1.TabIndex = 13;
            // 
            // lblTitTentativas
            // 
            this.lblTitTentativas.AutoSize = true;
            this.lblTitTentativas.Location = new System.Drawing.Point(22, 18);
            this.lblTitTentativas.Name = "lblTitTentativas";
            this.lblTitTentativas.Size = new System.Drawing.Size(115, 13);
            this.lblTitTentativas.TabIndex = 0;
            this.lblTitTentativas.Text = "Número de Tentativas:";
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.Location = new System.Drawing.Point(143, 18);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(14, 13);
            this.lblTentativas.TabIndex = 1;
            this.lblTentativas.Text = "0";
            // 
            // lblTitLetrasErradas
            // 
            this.lblTitLetrasErradas.AutoSize = true;
            this.lblTitLetrasErradas.Location = new System.Drawing.Point(22, 42);
            this.lblTitLetrasErradas.Name = "lblTitLetrasErradas";
            this.lblTitLetrasErradas.Size = new System.Drawing.Size(78, 13);
            this.lblTitLetrasErradas.TabIndex = 2;
            this.lblTitLetrasErradas.Text = "Letras Erradas:";
            // 
            // lblLetrasErradas
            // 
            this.lblLetrasErradas.AutoSize = true;
            this.lblLetrasErradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasErradas.Location = new System.Drawing.Point(143, 42);
            this.lblLetrasErradas.Name = "lblLetrasErradas";
            this.lblLetrasErradas.Size = new System.Drawing.Size(0, 13);
            this.lblLetrasErradas.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnJogo);
            this.Controls.Add(this.pnParametros);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.pnParametros.ResumeLayout(false);
            this.pnParametros.PerformLayout();
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnParametros;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Label lblTitPalSecreta;
        private System.Windows.Forms.TextBox txtPalavraSecreta;
        private System.Windows.Forms.Button btnMostraOcultaPalavra;
        private System.Windows.Forms.Label lblPalavraSecreta;
        private System.Windows.Forms.TextBox txtPalavraPesq;
        private System.Windows.Forms.Label lblTitJogoPalSecreta;
        private System.Windows.Forms.TextBox txtLetra10;
        private System.Windows.Forms.TextBox txtLetra09;
        private System.Windows.Forms.TextBox txtLetra08;
        private System.Windows.Forms.TextBox txtLetra07;
        private System.Windows.Forms.TextBox txtLetra06;
        private System.Windows.Forms.TextBox txtLetra05;
        private System.Windows.Forms.TextBox txtLetra04;
        private System.Windows.Forms.TextBox txtLetra03;
        private System.Windows.Forms.TextBox txtLetra02;
        private System.Windows.Forms.TextBox txtLetra01;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitTentativas;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblLetrasErradas;
        private System.Windows.Forms.Label lblTitLetrasErradas;
    }
}

