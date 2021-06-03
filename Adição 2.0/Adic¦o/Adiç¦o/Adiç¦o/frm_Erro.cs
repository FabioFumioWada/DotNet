using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adição
{
    public partial class frm_Erro : Form
    {
        public frm_Erro()
        {
            InitializeComponent();
        }

        private void btnErroOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
