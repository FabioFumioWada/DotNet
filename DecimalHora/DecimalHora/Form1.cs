using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecimalHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskChanged(object sender, EventArgs e)
        {
        }

        private void txtbxDecimalConverter_TextChanged(object sender, EventArgs e)
        {
        }

        private void mktbxHoraConverter_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conversão de Horas para Decimal
            // ((Hora*60) + Minutos)

            String horastr;
            Decimal hora;

            horastr = mktbxHoraConverter.Text;
            hora = (Convert.ToDecimal(horastr.Substring(0, 2)) * 60) +  //horas
                   (Convert.ToDecimal(horastr.Substring(3, 2)));        //minutos
            txtbxDecimalConvertido.Text = Convert.ToString(hora);
        }

        private void btnConvDecHor_Click(object sender, EventArgs e)
        {
        }
    }
}
