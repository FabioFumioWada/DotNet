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

        // variaveis globais
        string  vrletra01, vrletra02, vrletra03, vrletra04, vrletra05,
                vrletra06, vrletra07, vrletra08, vrletra09, vrletra10;

        decimal vrtentativas = 0,
                vrErros = 0,
                vrAcertos = 0;

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

        private void btnValidar_Click(object sender, EventArgs e)
        {
            vrtentativas = vrtentativas + 1;
            lblTentativas.Text = Convert.ToString(vrtentativas);

            if (txtPalavraSecreta.Text.Length == 1)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }

            }

            if (txtPalavraSecreta.Text.Length == 2)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 3)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 4)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 5)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 6)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra06.ToUpper())
                {
                    txtLetra06.BackColor = Color.Aqua;
                    txtLetra06.Text = vrletra06.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 7)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra06.ToUpper())
                {
                    txtLetra06.BackColor = Color.Aqua;
                    txtLetra06.Text = vrletra06.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra07.ToUpper())
                {
                    txtLetra07.BackColor = Color.Aqua;
                    txtLetra07.Text = vrletra07.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 8)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra06.ToUpper())
                {
                    txtLetra06.BackColor = Color.Aqua;
                    txtLetra06.Text = vrletra06.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra07.ToUpper())
                {
                    txtLetra07.BackColor = Color.Aqua;
                    txtLetra07.Text = vrletra07.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra08.ToUpper())
                {
                    txtLetra08.BackColor = Color.Aqua;
                    txtLetra08.Text = vrletra08.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }


            if (txtPalavraSecreta.Text.Length == 9)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra06.ToUpper())
                {
                    txtLetra06.BackColor = Color.Aqua;
                    txtLetra06.Text = vrletra06.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra07.ToUpper())
                {
                    txtLetra07.BackColor = Color.Aqua;
                    txtLetra07.Text = vrletra07.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra08.ToUpper())
                {
                    txtLetra08.BackColor = Color.Aqua;
                    txtLetra08.Text = vrletra08.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra09.ToUpper())
                {
                    txtLetra09.BackColor = Color.Aqua;
                    txtLetra09.Text = vrletra09.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }

            if (txtPalavraSecreta.Text.Length == 10)
            {
                if (txtPalavraPesq.Text.ToUpper() == vrletra01.ToUpper())
                {
                    txtLetra01.BackColor = Color.Aqua;
                    txtLetra01.Text = vrletra01.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra02.ToUpper())
                {
                    txtLetra02.BackColor = Color.Aqua;
                    txtLetra02.Text = vrletra02.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra03.ToUpper())
                {
                    txtLetra03.BackColor = Color.Aqua;
                    txtLetra03.Text = vrletra03.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra04.ToUpper())
                {
                    txtLetra04.BackColor = Color.Aqua;
                    txtLetra04.Text = vrletra04.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra05.ToUpper())
                {
                    txtLetra05.BackColor = Color.Aqua;
                    txtLetra05.Text = vrletra05.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra06.ToUpper())
                {
                    txtLetra06.BackColor = Color.Aqua;
                    txtLetra06.Text = vrletra06.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra07.ToUpper())
                {
                    txtLetra07.BackColor = Color.Aqua;
                    txtLetra07.Text = vrletra07.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra08.ToUpper())
                {
                    txtLetra08.BackColor = Color.Aqua;
                    txtLetra08.Text = vrletra08.ToUpper();
                }
                else if (txtPalavraPesq.Text.ToUpper() == vrletra09.ToUpper())
                {
                    txtLetra09.BackColor = Color.Aqua;
                    txtLetra09.Text = vrletra09.ToUpper();
                }
                else  if (txtPalavraPesq.Text.ToUpper() == vrletra10.ToUpper())
                {
                    txtLetra10.BackColor = Color.Aqua;
                    txtLetra10.Text = vrletra10.ToUpper();
                }
                else
                {
                    lblLetrasErradas.Text = lblLetrasErradas.Text+" "+txtPalavraPesq.Text.ToUpper();
                }
            }


            // volta cursor na caixa de pesquisa
            txtPalavraPesq.Focus();
        }

        private void txtPalavraSecreta_TextChanged(object sender, EventArgs e)
        {
            vrletra01 = "";
            vrletra02 = "";
            vrletra03 = "";
            vrletra04 = "";
            vrletra05 = "";
            vrletra06 = "";
            vrletra07 = "";
            vrletra08 = "";
            vrletra09 = "";
            vrletra10 = "";
            txtLetra01.Text = "";
            txtLetra02.Text = "";
            txtLetra03.Text = "";
            txtLetra04.Text = "";
            txtLetra05.Text = "";
            txtLetra06.Text = "";
            txtLetra07.Text = "";
            txtLetra08.Text = "";
            txtLetra09.Text = "";
            txtLetra10.Text = "";
            txtLetra01.BackColor = Color.White;
            txtLetra02.BackColor = Color.White;
            txtLetra03.BackColor = Color.White;
            txtLetra04.BackColor = Color.White;
            txtLetra05.BackColor = Color.White;
            txtLetra06.BackColor = Color.White;
            txtLetra07.BackColor = Color.White;
            txtLetra08.BackColor = Color.White;
            txtLetra09.BackColor = Color.White;
            txtLetra10.BackColor = Color.White;
            txtPalavraPesq.Text = "";
                        
            if (txtPalavraSecreta.Text.Length == 1)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                txtLetra01.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 2)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 3)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 4)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 5)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 6)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                vrletra06 = txtPalavraSecreta.Text.Substring(5, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
                txtLetra06.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 7)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                vrletra06 = txtPalavraSecreta.Text.Substring(5, 1);
                vrletra07 = txtPalavraSecreta.Text.Substring(6, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
                txtLetra06.Visible = true;
                txtLetra07.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 8)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                vrletra06 = txtPalavraSecreta.Text.Substring(5, 1);
                vrletra07 = txtPalavraSecreta.Text.Substring(6, 1);
                vrletra08 = txtPalavraSecreta.Text.Substring(7, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
                txtLetra06.Visible = true;
                txtLetra07.Visible = true;
                txtLetra08.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 9)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                vrletra06 = txtPalavraSecreta.Text.Substring(5, 1);
                vrletra07 = txtPalavraSecreta.Text.Substring(6, 1);
                vrletra08 = txtPalavraSecreta.Text.Substring(7, 1);
                vrletra09 = txtPalavraSecreta.Text.Substring(8, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
                txtLetra06.Visible = true;
                txtLetra07.Visible = true;
                txtLetra08.Visible = true;
                txtLetra09.Visible = true;
            }
            else if (txtPalavraSecreta.Text.Length == 10)
            {
                vrletra01 = txtPalavraSecreta.Text.Substring(0, 1);
                vrletra02 = txtPalavraSecreta.Text.Substring(1, 1);
                vrletra03 = txtPalavraSecreta.Text.Substring(2, 1);
                vrletra04 = txtPalavraSecreta.Text.Substring(3, 1);
                vrletra05 = txtPalavraSecreta.Text.Substring(4, 1);
                vrletra06 = txtPalavraSecreta.Text.Substring(5, 1);
                vrletra07 = txtPalavraSecreta.Text.Substring(6, 1);
                vrletra08 = txtPalavraSecreta.Text.Substring(7, 1);
                vrletra09 = txtPalavraSecreta.Text.Substring(8, 1);
                vrletra10 = txtPalavraSecreta.Text.Substring(9, 1);
                txtLetra01.Visible = true;
                txtLetra02.Visible = true;
                txtLetra03.Visible = true;
                txtLetra04.Visible = true;
                txtLetra05.Visible = true;
                txtLetra06.Visible = true;
                txtLetra07.Visible = true;
                txtLetra08.Visible = true;
                txtLetra09.Visible = true;
                txtLetra10.Visible = true;
            }
            else
            {
                vrletra01 = "";
                vrletra02 = "";
                vrletra03 = "";
                vrletra04 = "";
                vrletra05 = "";
                vrletra06 = "";
                vrletra07 = "";
                vrletra08 = "";
                vrletra09 = "";
                vrletra10 = "";
                txtLetra01.Visible = false;
                txtLetra02.Visible = false;
                txtLetra03.Visible = false;
                txtLetra04.Visible = false;
                txtLetra05.Visible = false;
                txtLetra06.Visible = false;
                txtLetra07.Visible = false;
                txtLetra08.Visible = false;
                txtLetra09.Visible = false;
                txtLetra10.Visible = false;
            }
        }

        private void pnJogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
