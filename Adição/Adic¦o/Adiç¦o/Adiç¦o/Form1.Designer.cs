namespace Adição
{
    partial class frmAdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicao));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblOperacao2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnProxCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(47, 37);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(25, 25);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "0";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(72, 37);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(19, 20);
            this.lblOperacao.TabIndex = 1;
            this.lblOperacao.Text = "+";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(97, 37);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(25, 25);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "0";
            // 
            // lblOperacao2
            // 
            this.lblOperacao2.AutoSize = true;
            this.lblOperacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao2.Location = new System.Drawing.Point(128, 41);
            this.lblOperacao2.Name = "lblOperacao2";
            this.lblOperacao2.Size = new System.Drawing.Size(19, 20);
            this.lblOperacao2.TabIndex = 3;
            this.lblOperacao2.Text = "=";
            this.lblOperacao2.Click += new System.EventHandler(this.lblOperacao2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(168, 35);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(39, 31);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidar.Location = new System.Drawing.Point(222, 41);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(50, 23);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "OK";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProxCalc
            // 
            this.btnProxCalc.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnProxCalc.Location = new System.Drawing.Point(222, 72);
            this.btnProxCalc.Name = "btnProxCalc";
            this.btnProxCalc.Size = new System.Drawing.Size(50, 23);
            this.btnProxCalc.TabIndex = 6;
            this.btnProxCalc.Text = ">>>";
            this.btnProxCalc.UseVisualStyleBackColor = false;
            this.btnProxCalc.Click += new System.EventHandler(this.btnProxCalc_Click);
            // 
            // frmAdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(this.btnProxCalc);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOperacao2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.lblValor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição / Soma ";
            this.Load += new System.EventHandler(this.frmAdicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblOperacao2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnProxCalc;
    }
}

