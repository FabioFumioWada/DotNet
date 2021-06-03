namespace Sistema_Binario
{
    partial class frmSistemaBinario
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
            this.cmbboxTipoValBin = new System.Windows.Forms.ComboBox();
            this.lblSelSistBinario = new System.Windows.Forms.Label();
            this.lblInfValBin = new System.Windows.Forms.Label();
            this.txtbxValorBinario = new System.Windows.Forms.TextBox();
            this.tbcSistemaBinario = new System.Windows.Forms.TabControl();
            this.tbpgInfCalc = new System.Windows.Forms.TabPage();
            this.btnConverter = new System.Windows.Forms.Button();
            this.tbpgResultado = new System.Windows.Forms.TabPage();
            this.lblResultTerabyte = new System.Windows.Forms.Label();
            this.lblTitResultTerabyte = new System.Windows.Forms.Label();
            this.lblResultGigabyte = new System.Windows.Forms.Label();
            this.lblTitResultGigabyte = new System.Windows.Forms.Label();
            this.lblResultMegabyte = new System.Windows.Forms.Label();
            this.lblTitResultMegabyte = new System.Windows.Forms.Label();
            this.lblResultKbyte = new System.Windows.Forms.Label();
            this.lblTitResultKbyte = new System.Windows.Forms.Label();
            this.lblResultByte = new System.Windows.Forms.Label();
            this.lblTitResulByte = new System.Windows.Forms.Label();
            this.lblResultBit = new System.Windows.Forms.Label();
            this.lblTitResultBit = new System.Windows.Forms.Label();
            this.tbcSistemaBinario.SuspendLayout();
            this.tbpgInfCalc.SuspendLayout();
            this.tbpgResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbboxTipoValBin
            // 
            this.cmbboxTipoValBin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbboxTipoValBin.FormattingEnabled = true;
            this.cmbboxTipoValBin.Items.AddRange(new object[] {
            "Bit",
            "Byte",
            "Kbyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte"});
            this.cmbboxTipoValBin.Location = new System.Drawing.Point(18, 46);
            this.cmbboxTipoValBin.Name = "cmbboxTipoValBin";
            this.cmbboxTipoValBin.Size = new System.Drawing.Size(165, 21);
            this.cmbboxTipoValBin.TabIndex = 0;
            // 
            // lblSelSistBinario
            // 
            this.lblSelSistBinario.AutoSize = true;
            this.lblSelSistBinario.Location = new System.Drawing.Point(15, 30);
            this.lblSelSistBinario.Name = "lblSelSistBinario";
            this.lblSelSistBinario.Size = new System.Drawing.Size(167, 13);
            this.lblSelSistBinario.TabIndex = 1;
            this.lblSelSistBinario.Text = "Selecione o Tipo de Valor Binário:";
            // 
            // lblInfValBin
            // 
            this.lblInfValBin.AutoSize = true;
            this.lblInfValBin.Location = new System.Drawing.Point(15, 95);
            this.lblInfValBin.Name = "lblInfValBin";
            this.lblInfValBin.Size = new System.Drawing.Size(352, 13);
            this.lblInfValBin.TabIndex = 2;
            this.lblInfValBin.Text = "Informe o valor binário de acordo com o tipo de valor binário selecionado:";
            // 
            // txtbxValorBinario
            // 
            this.txtbxValorBinario.Location = new System.Drawing.Point(18, 111);
            this.txtbxValorBinario.Name = "txtbxValorBinario";
            this.txtbxValorBinario.Size = new System.Drawing.Size(349, 20);
            this.txtbxValorBinario.TabIndex = 3;
            this.txtbxValorBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbcSistemaBinario
            // 
            this.tbcSistemaBinario.Controls.Add(this.tbpgInfCalc);
            this.tbcSistemaBinario.Controls.Add(this.tbpgResultado);
            this.tbcSistemaBinario.Location = new System.Drawing.Point(8, 45);
            this.tbcSistemaBinario.Name = "tbcSistemaBinario";
            this.tbcSistemaBinario.SelectedIndex = 0;
            this.tbcSistemaBinario.Size = new System.Drawing.Size(733, 254);
            this.tbcSistemaBinario.TabIndex = 4;
            // 
            // tbpgInfCalc
            // 
            this.tbpgInfCalc.Controls.Add(this.btnConverter);
            this.tbpgInfCalc.Controls.Add(this.lblSelSistBinario);
            this.tbpgInfCalc.Controls.Add(this.txtbxValorBinario);
            this.tbpgInfCalc.Controls.Add(this.cmbboxTipoValBin);
            this.tbpgInfCalc.Controls.Add(this.lblInfValBin);
            this.tbpgInfCalc.Location = new System.Drawing.Point(4, 22);
            this.tbpgInfCalc.Name = "tbpgInfCalc";
            this.tbpgInfCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgInfCalc.Size = new System.Drawing.Size(725, 228);
            this.tbpgInfCalc.TabIndex = 0;
            this.tbpgInfCalc.Text = "Inf. Cálculo";
            this.tbpgInfCalc.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(320, 160);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(135, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter/Calcular";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // tbpgResultado
            // 
            this.tbpgResultado.Controls.Add(this.lblResultTerabyte);
            this.tbpgResultado.Controls.Add(this.lblTitResultTerabyte);
            this.tbpgResultado.Controls.Add(this.lblResultGigabyte);
            this.tbpgResultado.Controls.Add(this.lblTitResultGigabyte);
            this.tbpgResultado.Controls.Add(this.lblResultMegabyte);
            this.tbpgResultado.Controls.Add(this.lblTitResultMegabyte);
            this.tbpgResultado.Controls.Add(this.lblResultKbyte);
            this.tbpgResultado.Controls.Add(this.lblTitResultKbyte);
            this.tbpgResultado.Controls.Add(this.lblResultByte);
            this.tbpgResultado.Controls.Add(this.lblTitResulByte);
            this.tbpgResultado.Controls.Add(this.lblResultBit);
            this.tbpgResultado.Controls.Add(this.lblTitResultBit);
            this.tbpgResultado.Location = new System.Drawing.Point(4, 22);
            this.tbpgResultado.Name = "tbpgResultado";
            this.tbpgResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgResultado.Size = new System.Drawing.Size(725, 228);
            this.tbpgResultado.TabIndex = 1;
            this.tbpgResultado.Text = "Resultado";
            this.tbpgResultado.UseVisualStyleBackColor = true;
            // 
            // lblResultTerabyte
            // 
            this.lblResultTerabyte.AutoSize = true;
            this.lblResultTerabyte.Location = new System.Drawing.Point(64, 154);
            this.lblResultTerabyte.Name = "lblResultTerabyte";
            this.lblResultTerabyte.Size = new System.Drawing.Size(13, 13);
            this.lblResultTerabyte.TabIndex = 11;
            this.lblResultTerabyte.Text = "0";
            // 
            // lblTitResultTerabyte
            // 
            this.lblTitResultTerabyte.AutoSize = true;
            this.lblTitResultTerabyte.Location = new System.Drawing.Point(6, 154);
            this.lblTitResultTerabyte.Name = "lblTitResultTerabyte";
            this.lblTitResultTerabyte.Size = new System.Drawing.Size(49, 13);
            this.lblTitResultTerabyte.TabIndex = 10;
            this.lblTitResultTerabyte.Text = "Terabyte";
            // 
            // lblResultGigabyte
            // 
            this.lblResultGigabyte.AutoSize = true;
            this.lblResultGigabyte.Location = new System.Drawing.Point(64, 127);
            this.lblResultGigabyte.Name = "lblResultGigabyte";
            this.lblResultGigabyte.Size = new System.Drawing.Size(13, 13);
            this.lblResultGigabyte.TabIndex = 9;
            this.lblResultGigabyte.Text = "0";
            // 
            // lblTitResultGigabyte
            // 
            this.lblTitResultGigabyte.AutoSize = true;
            this.lblTitResultGigabyte.Location = new System.Drawing.Point(6, 127);
            this.lblTitResultGigabyte.Name = "lblTitResultGigabyte";
            this.lblTitResultGigabyte.Size = new System.Drawing.Size(49, 13);
            this.lblTitResultGigabyte.TabIndex = 8;
            this.lblTitResultGigabyte.Text = "Gigabyte";
            // 
            // lblResultMegabyte
            // 
            this.lblResultMegabyte.AutoSize = true;
            this.lblResultMegabyte.Location = new System.Drawing.Point(64, 102);
            this.lblResultMegabyte.Name = "lblResultMegabyte";
            this.lblResultMegabyte.Size = new System.Drawing.Size(13, 13);
            this.lblResultMegabyte.TabIndex = 7;
            this.lblResultMegabyte.Text = "0";
            // 
            // lblTitResultMegabyte
            // 
            this.lblTitResultMegabyte.AutoSize = true;
            this.lblTitResultMegabyte.Location = new System.Drawing.Point(6, 102);
            this.lblTitResultMegabyte.Name = "lblTitResultMegabyte";
            this.lblTitResultMegabyte.Size = new System.Drawing.Size(54, 13);
            this.lblTitResultMegabyte.TabIndex = 6;
            this.lblTitResultMegabyte.Text = "Megabyte";
            // 
            // lblResultKbyte
            // 
            this.lblResultKbyte.AutoSize = true;
            this.lblResultKbyte.Location = new System.Drawing.Point(64, 74);
            this.lblResultKbyte.Name = "lblResultKbyte";
            this.lblResultKbyte.Size = new System.Drawing.Size(13, 13);
            this.lblResultKbyte.TabIndex = 5;
            this.lblResultKbyte.Text = "0";
            // 
            // lblTitResultKbyte
            // 
            this.lblTitResultKbyte.AutoSize = true;
            this.lblTitResultKbyte.Location = new System.Drawing.Point(6, 74);
            this.lblTitResultKbyte.Name = "lblTitResultKbyte";
            this.lblTitResultKbyte.Size = new System.Drawing.Size(34, 13);
            this.lblTitResultKbyte.TabIndex = 4;
            this.lblTitResultKbyte.Text = "Kbyte";
            // 
            // lblResultByte
            // 
            this.lblResultByte.AutoSize = true;
            this.lblResultByte.Location = new System.Drawing.Point(64, 47);
            this.lblResultByte.Name = "lblResultByte";
            this.lblResultByte.Size = new System.Drawing.Size(13, 13);
            this.lblResultByte.TabIndex = 3;
            this.lblResultByte.Text = "0";
            // 
            // lblTitResulByte
            // 
            this.lblTitResulByte.AutoSize = true;
            this.lblTitResulByte.Location = new System.Drawing.Point(6, 47);
            this.lblTitResulByte.Name = "lblTitResulByte";
            this.lblTitResulByte.Size = new System.Drawing.Size(28, 13);
            this.lblTitResulByte.TabIndex = 2;
            this.lblTitResulByte.Text = "Byte";
            // 
            // lblResultBit
            // 
            this.lblResultBit.AutoSize = true;
            this.lblResultBit.Location = new System.Drawing.Point(64, 20);
            this.lblResultBit.Name = "lblResultBit";
            this.lblResultBit.Size = new System.Drawing.Size(13, 13);
            this.lblResultBit.TabIndex = 1;
            this.lblResultBit.Text = "0";
            // 
            // lblTitResultBit
            // 
            this.lblTitResultBit.AutoSize = true;
            this.lblTitResultBit.Location = new System.Drawing.Point(6, 20);
            this.lblTitResultBit.Name = "lblTitResultBit";
            this.lblTitResultBit.Size = new System.Drawing.Size(19, 13);
            this.lblTitResultBit.TabIndex = 0;
            this.lblTitResultBit.Text = "Bit";
            // 
            // frmSistemaBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 307);
            this.Controls.Add(this.tbcSistemaBinario);
            this.MaximizeBox = false;
            this.Name = "frmSistemaBinario";
            this.Text = "Calculo do Sistema Binário";
            this.tbcSistemaBinario.ResumeLayout(false);
            this.tbpgInfCalc.ResumeLayout(false);
            this.tbpgInfCalc.PerformLayout();
            this.tbpgResultado.ResumeLayout(false);
            this.tbpgResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxTipoValBin;
        private System.Windows.Forms.Label lblSelSistBinario;
        private System.Windows.Forms.Label lblInfValBin;
        private System.Windows.Forms.TextBox txtbxValorBinario;
        private System.Windows.Forms.TabControl tbcSistemaBinario;
        private System.Windows.Forms.TabPage tbpgInfCalc;
        private System.Windows.Forms.TabPage tbpgResultado;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultBit;
        private System.Windows.Forms.Label lblTitResultBit;
        private System.Windows.Forms.Label lblResultByte;
        private System.Windows.Forms.Label lblTitResulByte;
        private System.Windows.Forms.Label lblResultGigabyte;
        private System.Windows.Forms.Label lblTitResultGigabyte;
        private System.Windows.Forms.Label lblResultMegabyte;
        private System.Windows.Forms.Label lblTitResultMegabyte;
        private System.Windows.Forms.Label lblResultKbyte;
        private System.Windows.Forms.Label lblTitResultKbyte;
        private System.Windows.Forms.Label lblResultTerabyte;
        private System.Windows.Forms.Label lblTitResultTerabyte;
    }
}

