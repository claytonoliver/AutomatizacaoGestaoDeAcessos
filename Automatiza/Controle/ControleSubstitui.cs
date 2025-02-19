using Automatiza.Controle.VariaveisPublicas;
using Automatiza.Enum;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = ClosedXML.Excel;

namespace Automatiza.Controle
{
    public class ControleSubstitui
    {
        public frm_substituicao _frm_substituicao { get; set; }
        public StatusEnum status { get; set; }

        private const string CamonhoArquivoConcecao = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\concecao Substituição\";
        private const string CamonhoArquivoRevogacao = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação Substituição\";
        public void ValidaAcaoSelecionada()
        {
            if (_frm_substituicao.cb_concecao.Checked == true)
            {
                status = StatusEnum.concecao;
            }
            else
            {
                status = StatusEnum.revogacao;
            }
        }
        public void cria(frm_substituicao frm)
        {
            _frm_substituicao = frm;

            var NomeArquivo = new Dictionary<int, string> {
                { 1, "Revoga tesoureiro X gerente ADM.xlsx"},
                { 2, "Revoga gerente contas X gerente PA.xlsx"},
                { 3, "Revoga caixa X tesoureiro.xlsx"},
            };


            if (frm.cb_concecao.Checked == true)
            {
                
                if (frm.RB_1.Checked == true)
                {
                    PublicVar.Caminho = @"Revoga tesoureiro X gerente ADM.xlsx";
                    PublicVar.Escolha = "1";
                }
                if (frm.RB_2.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\concecao Substituição\Revoga gerente contas X gerente PA.xlsx";
                    PublicVar.Escolha = "2";
                }
                if (frm.RB_3.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\concecao Substituição\Revoga caixa X tesoureiro.xlsx";
                    PublicVar.Escolha = "3";
                }
            }

            else if (frm.cb_revogacao.Checked == true)
            {
                PublicVar.Status = "Revogar Acessos";
                if (frm.RB_1.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação Substituição\Revoga tesoureiro X gerente ADM.xlsx";
                    PublicVar.Escolha = "1";
                }
                if (frm.RB_2.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação Substituição\Revoga gerente contas X gerente PA.xlsx";
                    PublicVar.Escolha = "2";
                }
                if (frm.RB_3.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação Substituição\Revoga caixa X tesoureiro.xlsx";
                    PublicVar.Escolha = "3";
                }

            }

            PublicVar.UsrSisbr = frm.TB_name.Text;


            if (frm.SelectBase.Checked == true)
            {
                PublicVar.BasePA = frm.TB_base.Text;
            }
            else
            {

                MatchCollection matches = Regex.Matches(PublicVar.UsrSisbr, @"\d+");
                PublicVar.BasePA = matches[matches.Count - 1].Value;

            }





            //Vai opegar o caminho com base a planilha
            var xls = new Excel.XLWorkbook(PublicVar.Caminho);

            //pega o nome da sheet
            var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();
            var cells = "D7:D100";

            //valida a escolha
            switch (PublicVar.Escolha)
            {
                case "1":
                    cells = "D7:D21";
                    planilha.Cells("C9:C21").Value = PublicVar.BasePA;
                    break;

                case "2":
                    cells = "D7:D11";
                    planilha.Cells("C8:C11").Value = PublicVar.BasePA;
                    break;

                case "3":
                    cells = "D7:D12";
                    planilha.Cells("C9:C12").Value = PublicVar.BasePA;
                    break;
            }

            planilha.Cells(cells).Value = PublicVar.UsrSisbr;

            //validação sobre os checkbox conceção e revogação

            PublicVar.identificador = frm.TB_identifica.Text;

            if (frm.cb_concecao.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "conc subs " + PublicVar.identificador + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\Concessão\" + dataAtual;
                PublicVar.CaminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(PublicVar.CaminhoArquivo);

            }

            else if (frm.cb_revogacao.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "rev subs " + PublicVar.identificador + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\revogação\" + dataAtual;
                PublicVar.CaminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(PublicVar.CaminhoArquivo);
            }

        }
        public static void DigitaBase(frm_substituicao frm)
        {


            if (frm.SelectBase.Checked == true)
            {
                frm.LB_base.Visible = true;
                frm.TB_base.Visible = true;

            }
            else
            {
                frm.LB_base.Visible = false;
                frm.TB_base.Visible = false;

            }
        }

    }



}
