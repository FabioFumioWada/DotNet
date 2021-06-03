namespace Regra_de_3
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtbxbValor1 = new System.Windows.Forms.TextBox();
            this.txtbxbValor2 = new System.Windows.Forms.TextBox();
            this.txtbxbValor3 = new System.Windows.Forms.TextBox();
            this.lblSeta2 = new System.Windows.Forms.Label();
            this.lblSeta1 = new System.Windows.Forms.Label();
            this.txtbxbValor4 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCalculo = new System.Windows.Forms.Label();
            this.lblValorCalculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtbxbValor1
            // 
            this.txtbxbValor1.Location = new System.Drawing.Point(25, 48);
            this.txtbxbValor1.Name = "txtbxbValor1";
            this.txtbxbValor1.Size = new System.Drawing.Size(100, 20);
            this.txtbxbValor1.TabIndex = 1;
            this.txtbxbValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxbValor2
            // 
            this.txtbxbValor2.Location = new System.Drawing.Point(180, 48);
            this.txtbxbValor2.Name = "txtbxbValor2";
            this.txtbxbValor2.Size = new System.Drawing.Size(100, 20);
            this.txtbxbValor2.TabIndex = 2;
            this.txtbxbValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxbValor3
            // 
            this.txtbxbValor3.Location = new System.Drawing.Point(25, 104);
            this.txtbxbValor3.Name = "txtbxbValor3";
            this.txtbxbValor3.Size = new System.Drawing.Size(100, 20);
            this.txtbxbValor3.TabIndex = 3;
            this.txtbxbValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSeta2
            // 
            this.lblSeta2.AutoSize = true;
            this.lblSeta2.Location = new System.Drawing.Point(131, 104);
            this.lblSeta2.Name = "lblSeta2";
            this.lblSeta2.Size = new System.Drawing.Size(43, 13);
            this.lblSeta2.TabIndex = 5;
            this.lblSeta2.Text = "---------->";
            // 
            // lblSeta1
            // 
            this.lblSeta1.AutoSize = true;
            this.lblSeta1.Location = new System.Drawing.Point(131, 48);
            this.lblSeta1.Name = "lblSeta1";
            this.lblSeta1.Size = new System.Drawing.Size(43, 13);
            this.lblSeta1.TabIndex = 6;
            this.lblSeta1.Text = "---------->";
            // 
            // txtbxbValor4
            // 
            this.txtbxbValor4.Location = new System.Drawing.Point(180, 104);
            this.txtbxbValor4.Name = "txtbxbValor4";
            this.txtbxbValor4.ReadOnly = true;
            this.txtbxbValor4.Size = new System.Drawing.Size(100, 20);
            this.txtbxbValor4.TabIndex = 4;
            this.txtbxbValor4.Text = "X";
            this.txtbxbValor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(22, 32);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 7;
            this.lblValor1.Text = "Valor 1";
            this.lblValor1.Click += new System.EventHandler(this.lblValor1_Click);
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(22, 88);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(40, 13);
            this.lblValor3.TabIndex = 8;
            this.lblValor3.Text = "Valor 3";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(177, 32);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 9;
            this.lblValor2.Text = "Valor 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor a ser Calculado";
            // 
            // lblTituloCalculo
            // 
            this.lblTituloCalculo.AutoSize = true;
            this.lblTituloCalculo.Location = new System.Drawing.Point(22, 194);
            this.lblTituloCalculo.Name = "lblTituloCalculo";
            this.lblTituloCalculo.Size = new System.Drawing.Size(58, 13);
            this.lblTituloCalculo.TabIndex = 11;
            this.lblTituloCalculo.Text = "Resultado:";
            this.lblTituloCalculo.Visible = false;
            // 
            // lblValorCalculo
            // 
            this.lblValorCalculo.AutoSize = true;
            this.lblValorCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCalculo.Location = new System.Drawing.Point(86, 194);
            this.lblValorCalculo.Name = "lblValorCalculo";
            this.lblValorCalculo.Size = new System.Drawing.Size(180, 20);
            this.lblValorCalculo.TabIndex = 12;
            this.lblValorCalculo.Text = "Valor a ser Calculado";
            this.lblValorCalculo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 231);
            this.Controls.Add(this.lblValorCalculo);
            this.Controls.Add(this.lblTituloCalculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtbxbValor4);
            this.Controls.Add(this.lblSeta1);
            this.Controls.Add(this.lblSeta2);
            this.Controls.Add(this.txtbxbValor3);
            this.Controls.Add(this.txtbxbValor2);
            this.Controls.Add(this.txtbxbValor1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Regra de 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtbxbValor1;
        private System.Windows.Forms.TextBox txtbxbValor2;
        private System.Windows.Forms.TextBox txtbxbValor3;
        private System.Windows.Forms.Label lblSeta2;
        private System.Windows.Forms.Label lblSeta1;
        private System.Windows.Forms.TextBox txtbxbValor4;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloCalculo;
        private System.Windows.Forms.Label lblValorCalculo;
    }
}

