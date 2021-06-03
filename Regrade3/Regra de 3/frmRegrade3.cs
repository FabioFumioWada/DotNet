using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Regra_de_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double  Valor1, 
                    Valor2, 
                    Valor3, 
                    ValorResultado;

            Valor1 =    Convert.ToDouble(txtbxbValor1.Text);
            Valor2 =    Convert.ToDouble(txtbxbValor2.Text);
            Valor3 =    Convert.ToDouble(txtbxbValor3.Text);

            ValorResultado =    ((Valor3 * Valor2) / Valor1);

            lblTituloCalculo.Visible =  true;
            lblValorCalculo.Visible =   true;
                   
            lblValorCalculo.Text = Convert.ToString(ValorResultado);
        }
    }
}
