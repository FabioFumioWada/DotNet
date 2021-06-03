using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // função beep

namespace Adição
{
    public partial class frmAdicao : Form
    {
        // Variável Global
        DateTime DataHoraAtual;
        String DataHoraAtualString;

         // função beep
            /*
                [DllImport("kernel32.dll")]
                public static extern bool Beep(UInt32 frequency, UInt32 duration);
            */
       
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);
       
        public frmAdicao()
        {
            InitializeComponent();
        }

        // procedure manual
        private void Reinicia_Calculo()
        {
            // Iniciando - Reiniciando o exercício
            string ValorTmp;

            txtResultado.Text = "";
            txtResultado.Focus();
            DataHoraAtual = DateTime.Now;
            DataHoraAtualString = DataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
            lblValor1.Text = DataHoraAtualString.Substring(17, 1);
            lblValor2.Text = DataHoraAtualString.Substring(18, 1);

            // O primeiro valor sempre será maior que o segundo valor
            if (Convert.ToDecimal(lblValor1.Text) < Convert.ToDecimal(lblValor2.Text))
            {
                ValorTmp = lblValor1.Text;
                lblValor1.Text = lblValor2.Text;
                lblValor2.Text = ValorTmp;
            }

        }

        private void frmAdicao_Load(object sender, EventArgs e)
        {
            // Iniciando o exercício
            Reinicia_Calculo(); //procedure criada manualmente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //carregar forms de acerto e de erro
            frm_Acerto frm_Acerto = new frm_Acerto();     // Form de acerto   
            frm_Erro frm_Erro = new frm_Erro(); // Form de erro

            decimal resultado,
                    valor1,
                    valor2;

            valor1 = Convert.ToDecimal(lblValor1.Text);
            valor2 = Convert.ToDecimal(lblValor2.Text);

            resultado = (valor1 - valor2);

            if (txtResultado.Text == "")
            {
                MessageBox.Show("Informe o Valor do Resultado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtResultado.Text = "";
                txtResultado.Focus();
            }
            else
            {
                // -- resultado correto
                if (resultado == Convert.ToDecimal(txtResultado.Text))
                {
                    //Beep(1000, 200);
                    //MessageBox.Show("Correto! Parabéns!!!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Acerto.Show();
                    frm_Acerto.Activate();
                    frm_Acerto.Focus();
                    // -- Mudando o exercício
                    Reinicia_Calculo(); //procedure criada manualmente

                }
                // -- resultado incorreto
                else
                {
                    //Beep(500, 100);
//                    MessageBox.Show("Errado! Tente Novamente!!!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    frm_Erro.Show();
                    frm_Erro.Activate();
                    frm_Erro.Focus();
                    txtResultado.Text = "";
                    txtResultado.Focus();
                }
            }
        }

        private void lblOperacao2_Click(object sender, EventArgs e)
        {            
        }

        private void btnProxCalc_Click(object sender, EventArgs e)
        {
            // -- Mudando o exercício
            Reinicia_Calculo(); //procedure criada manualmente
        }
    }
}
