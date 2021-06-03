using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Binario
{
    public partial class frmSistemaBinario : Form
    {
        public frmSistemaBinario()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string BinarioSelecionado;
            int tamanhobytes, tamanhodemais;

            tamanhobytes = 8;
            tamanhodemais = 1024;
            BinarioSelecionado = cmbboxTipoValBin.Text;   //cmbboxTipoValBin.SelectedValue();

            if (BinarioSelecionado == "Bit")
            {
                lblResultBit.Text = Convert.ToString(txtbxValorBinario.Text);
                lblResultByte.Text = Convert.ToString((Convert.ToDouble(txtbxValorBinario.Text) / tamanhobytes));
                lblResultKbyte.Text = Convert.ToString((Convert.ToDouble(txtbxValorBinario.Text) / tamanhodemais));

            }

            if (BinarioSelecionado == "Byte")
            {
                lblResultByte.Text = Convert.ToString(txtbxValorBinario.Text);
                
            }



        }

    }
}
