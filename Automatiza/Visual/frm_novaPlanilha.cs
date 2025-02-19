using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using Excel = ClosedXML.Excel;
using System.Runtime.Intrinsics.X86;

namespace Automatiza
{
    public partial class novaPlanilha : Form
    {
        public novaPlanilha()
        {
            InitializeComponent();
        }

        private void novaPlanilha_Load(object sender, EventArgs e)
        {

        }

        private void Bt_cria_Click(object sender, EventArgs e)
        {
            var caminho = "Z:\\Suporte\\- GESTÃO DE ACESSOS\\CCS-grupos-fluxos\\01\\modelo_limpo.xlsx";

            var xls = new Excel.XLWorkbook(caminho);
            var planilha = xls.Worksheets.First(w => w.Name == "acesso");
            var totalLinhas = planilha.Rows().Count();



            var bsPA = tb_bspan.Text;
            var lgusr = tb_loginn.Text;
            var fluxos = tb_fluxo.Text;
            var nmA = tb_nomearq.Text;

            if (cb_concecao.Checked == true)
            {
                planilha.Cells("C7").Value = bsPA;
                planilha.Cells("D7").Value = lgusr;
                planilha.Cells("E7").Value = fluxos;


            }
            else if (cb_revoga.Checked == true)
            {
                planilha.Cells("C7").Value = bsPA;
                planilha.Cells("D7").Value = lgusr;
                planilha.Cells("F7").Value = fluxos;

            }


            if (cb_concecao.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "concessao unico " + nmA + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\Concessão\" + dataAtual;
                string caminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(caminhoArquivo);
                xls.SaveAs(caminhoArquivo);
            }
            else if (cb_revoga.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "revogação unico " + nmA + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\revogação\" + dataAtual;
                string caminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(caminhoArquivo);
            }


            MessageBox.Show("Planilha criada");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_concecao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
