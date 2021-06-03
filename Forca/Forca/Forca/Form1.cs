using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostraOcultaPalavra_Click(object sender, EventArgs e)
        {
            if (lblPalavraSecreta.Visible == false)
            {
                lblPalavraSecreta.Visible = true;
                lblPalavraSecreta.Text = txtPalavraSecreta.Text.ToUpper();
                btnMostraOcultaPalavra.Text = "Ocultar";
            }
            else
            {
                lblPalavraSecreta.Visible = false;
                //lblPalavraSecreta.Text = txtPalavraSecreta.Text;
                btnMostraOcultaPalavra.Text = "Mostrar";
            }
        }
    }
}
