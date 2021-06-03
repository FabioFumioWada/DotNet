namespace DecimalHora
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
            this.mktbxHoraConverter = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraConverter = new System.Windows.Forms.Label();
            this.txtbxDecimalConvertido = new System.Windows.Forms.TextBox();
            this.lblDecimalConvertido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mktbxHoraConvertida = new System.Windows.Forms.MaskedTextBox();
            this.txtbxDecimalConverter = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraConvertida = new System.Windows.Forms.Label();
            this.lblDecimalConverter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvHorDec = new System.Windows.Forms.Button();
            this.btnConvDecHor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mktbxHoraConverter
            // 
            this.mktbxHoraConverter.Location = new System.Drawing.Point(6, 34);
            this.mktbxHoraConverter.Mask = "90:00";
            this.mktbxHoraConverter.Name = "mktbxHoraConverter";
            this.mktbxHoraConverter.Size = new System.Drawing.Size(39, 20);
            this.mktbxHoraConverter.TabIndex = 0;
            this.mktbxHoraConverter.ValidatingType = typeof(System.DateTime);
            this.mktbxHoraConverter.MaskChanged += new System.EventHandler(this.maskedTextBox1_MaskChanged);
            this.mktbxHoraConverter.TextChanged += new System.EventHandler(this.mktbxHoraConverter_TextChanged);
            // 
            // lblHoraConverter
            // 
            this.lblHoraConverter.AutoSize = true;
            this.lblHoraConverter.Location = new System.Drawing.Point(3, 18);
            this.lblHoraConverter.Name = "lblHoraConverter";
            this.lblHoraConverter.Size = new System.Drawing.Size(159, 13);
            this.lblHoraConverter.TabIndex = 3;
            this.lblHoraConverter.Text = "Informe a Hora a ser convertida:";
            // 
            // txtbxDecimalConvertido
            // 
            this.txtbxDecimalConvertido.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxDecimalConvertido.Enabled = false;
            this.txtbxDecimalConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDecimalConvertido.ForeColor = System.Drawing.Color.Red;
            this.txtbxDecimalConvertido.Location = new System.Drawing.Point(6, 85);
            this.txtbxDecimalConvertido.Name = "txtbxDecimalConvertido";
            this.txtbxDecimalConvertido.Size = new System.Drawing.Size(100, 20);
            this.txtbxDecimalConvertido.TabIndex = 4;
            // 
            // lblDecimalConvertido
            // 
            this.lblDecimalConvertido.AutoSize = true;
            this.lblDecimalConvertido.Location = new System.Drawing.Point(3, 69);
            this.lblDecimalConvertido.Name = "lblDecimalConvertido";
            this.lblDecimalConvertido.Size = new System.Drawing.Size(101, 13);
            this.lblDecimalConvertido.TabIndex = 5;
            this.lblDecimalConvertido.Text = "Decimal convertido:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblHoraConverter);
            this.panel1.Controls.Add(this.mktbxHoraConverter);
            this.panel1.Controls.Add(this.lblDecimalConvertido);
            this.panel1.Controls.Add(this.txtbxDecimalConvertido);
            this.panel1.Location = new System.Drawing.Point(24, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 114);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conversor (Hora/Decimal)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mktbxHoraConvertida);
            this.panel2.Controls.Add(this.txtbxDecimalConverter);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.lblHoraConvertida);
            this.panel2.Controls.Add(this.lblDecimalConverter);
            this.panel2.Location = new System.Drawing.Point(229, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 114);
            this.panel2.TabIndex = 8;
            // 
            // mktbxHoraConvertida
            // 
            this.mktbxHoraConvertida.BackColor = System.Drawing.SystemColors.Window;
            this.mktbxHoraConvertida.Enabled = false;
            this.mktbxHoraConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktbxHoraConvertida.ForeColor = System.Drawing.Color.Red;
            this.mktbxHoraConvertida.Location = new System.Drawing.Point(7, 85);
            this.mktbxHoraConvertida.Mask = "90:00";
            this.mktbxHoraConvertida.Name = "mktbxHoraConvertida";
            this.mktbxHoraConvertida.Size = new System.Drawing.Size(39, 20);
            this.mktbxHoraConvertida.TabIndex = 6;
            this.mktbxHoraConvertida.ValidatingType = typeof(System.DateTime);
            // 
            // txtbxDecimalConverter
            // 
            this.txtbxDecimalConverter.Location = new System.Drawing.Point(7, 34);
            this.txtbxDecimalConverter.Name = "txtbxDecimalConverter";
            this.txtbxDecimalConverter.Size = new System.Drawing.Size(100, 20);
            this.txtbxDecimalConverter.TabIndex = 6;
            this.txtbxDecimalConverter.TextChanged += new System.EventHandler(this.txtbxDecimalConverter_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 115);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraConvertida
            // 
            this.lblHoraConvertida.AutoSize = true;
            this.lblHoraConvertida.Location = new System.Drawing.Point(4, 69);
            this.lblHoraConvertida.Name = "lblHoraConvertida";
            this.lblHoraConvertida.Size = new System.Drawing.Size(86, 13);
            this.lblHoraConvertida.TabIndex = 7;
            this.lblHoraConvertida.Text = "Hora convertida:";
            // 
            // lblDecimalConverter
            // 
            this.lblDecimalConverter.AutoSize = true;
            this.lblDecimalConverter.Location = new System.Drawing.Point(4, 18);
            this.lblDecimalConverter.Name = "lblDecimalConverter";
            this.lblDecimalConverter.Size = new System.Drawing.Size(174, 13);
            this.lblDecimalConverter.TabIndex = 9;
            this.lblDecimalConverter.Text = "Informe o Decimal a ser convertido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conversor (Decimal/Hora)";
            // 
            // btnConvHorDec
            // 
            this.btnConvHorDec.Location = new System.Drawing.Point(44, 155);
            this.btnConvHorDec.Name = "btnConvHorDec";
            this.btnConvHorDec.Size = new System.Drawing.Size(144, 23);
            this.btnConvHorDec.TabIndex = 10;
            this.btnConvHorDec.Text = "Converter (Hora/Decimal)";
            this.btnConvHorDec.UseVisualStyleBackColor = true;
            this.btnConvHorDec.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvDecHor
            // 
            this.btnConvDecHor.Location = new System.Drawing.Point(245, 155);
            this.btnConvDecHor.Name = "btnConvDecHor";
            this.btnConvDecHor.Size = new System.Drawing.Size(144, 23);
            this.btnConvDecHor.TabIndex = 11;
            this.btnConvDecHor.Text = "Converter (Decimal/Hora)";
            this.btnConvDecHor.UseVisualStyleBackColor = true;
            this.btnConvDecHor.Click += new System.EventHandler(this.btnConvDecHor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 209);
            this.Controls.Add(this.btnConvDecHor);
            this.Controls.Add(this.btnConvHorDec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tomodachi - Conversor (Hora&Decimal) - CorporeRM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mktbxHoraConverter;
        private System.Windows.Forms.Label lblHoraConverter;
        private System.Windows.Forms.TextBox txtbxDecimalConvertido;
        private System.Windows.Forms.Label lblDecimalConvertido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxDecimalConverter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblHoraConvertida;
        private System.Windows.Forms.Label lblDecimalConverter;
        private System.Windows.Forms.MaskedTextBox mktbxHoraConvertida;
        private System.Windows.Forms.Button btnConvHorDec;
        private System.Windows.Forms.Button btnConvDecHor;
    }
}

