using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatiza.Visual
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_IniciarSoliciacao_Click(object sender, EventArgs e)
        {
            var frm_solicitacao = new Frm_Solicitacao();
            AbrirForm(frm_solicitacao);
        }


        private void AbrirForm(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2, (this.ClientSize.Height - frm.Height) / 2);
            frm.Show();
        }

    }
}
