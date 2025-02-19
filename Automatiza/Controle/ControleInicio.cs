using Automatiza.Controle.VariaveisPublicas;
using System.Text.RegularExpressions;
using Excel = ClosedXML.Excel;

namespace Automatiza.Controle
{

    public class ControleInicio
    {
        
        public static void ValidaOpcoes(Frm_inicio frm)
        {

            if (frm.cb_concecao.Checked == true)
            {
                PublicVar.Status = "Conceder acessos";

                //assistente
                if (frm.RB_1.Checked == true)
                {
                    PublicVar.Caminho = "Y:\\- Installs - FILIAIS\\Gabrielle\\Permissões\\Concecao\\Assistente atendimento.xlsx";
                    PublicVar.Escolha = "1";
                }
                //caixa tesoureiro
                if (frm.RB_2.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Tesoureiro.xlsx";
                    PublicVar.Escolha = "2";
                }
                //caixa
                if (frm.RB_3.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Caixa.xlsx";
                    PublicVar.Escolha = "3";
                }
                //estagiario
                if (frm.RB_4.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Estagiário PA.xlsx";
                    PublicVar.Escolha = "4";
                }
                //gerente adm
                if (frm.RB_5.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Gerente ADM.xlsx";
                    PublicVar.Escolha = "5";
                }
                //gerente de contas
                if (frm.RB_7.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Gerente PA.xlsx";
                    PublicVar.Escolha = "7";
                }
                //gerente de contas
                if (frm.RB_8.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\Concecao\Gerente Contas.xlsx";
                    PublicVar.Escolha = "8";
                }
                
            }
            else if (frm.cb_revoga.Checked == true)
            {
                PublicVar.Status = "Revogar Acessos";
                if (frm.RB_1.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Assistente atendimento.xlsx";
                    PublicVar.Escolha = "1";
                }
                if (frm.RB_2.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Tesoureiro.xlsx";
                    PublicVar.Escolha = "2";
                }
                if (frm.RB_3.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Caixa.xlsx";
                    PublicVar.Escolha = "3";
                }
                if (frm.RB_4.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Estagiário PA.xlsx";
                    PublicVar.Escolha = "4";
                }
                if (frm.RB_5.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Gerente ADM.xlsx";
                    PublicVar.Escolha = "5";
                }
                if (frm.RB_7.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Gerente PA.xlsx";
                    PublicVar.Escolha = "7";
                }
                if (frm.RB_8.Checked == true)
                {
                    PublicVar.Caminho = @"Y:\- Installs - FILIAIS\Gabrielle\Permissões\revogação\Gerente Contas.xlsx";
                    PublicVar.Escolha = "8";
                }
            }
        }

        public static void DigitaBase(Frm_inicio frm)
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
    public static void CriaPlanilha(Frm_inicio frm)
    {
            
            PublicVar.UsrSisbr = frm.TB_name.Text;

            if (frm.SelectBase.Checked)
            {
                PublicVar.BasePA = frm.TB_base.Text;
            }
            else
            {
                MatchCollection matches = Regex.Matches(PublicVar.UsrSisbr, @"\d+");
                PublicVar.BasePA = matches[matches.Count - 1].Value;

                if (PublicVar.BasePA.Length > 2)
                {
                    MessageBox.Show("Não pode!");
                }
            }

            //Vai opegar o caminho com base a planilha
            var xls = new Excel.XLWorkbook(PublicVar.Caminho);

            //pega o nome da sheet
            var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();
            var cells = "C19:C60";
            switch (PublicVar.Escolha)
            {
                case "1":
                    cells = "D7:D60";
                    planilha.Cells("C19:C60").Value = PublicVar.BasePA;
                    break;

                case "2":
                    cells = "D7:D47";
                    planilha.Cells("C14:C47").Value = PublicVar.BasePA;
                    break;

                case "3":
                    cells = "D7:D41";
                    planilha.Cells("C12:C41").Value = PublicVar.BasePA;
                    break;

                case "4":
                    cells = "D7:D15";
                    planilha.Cells("C11:C15").Value = PublicVar.BasePA;
                    break;

                case "5":
                    cells = "D7:D60";
                    planilha.Cells("C16:C60").Value = PublicVar.BasePA;
                    break;

                case "7":
                    cells = "D7:D74";
                    planilha.Cells("C25:C74").Value = PublicVar.BasePA;
                    break;

                case "8":
                    cells = "D7:D75";
                    planilha.Cells("C24:C75").Value = PublicVar.BasePA;
                    break;
            }


            planilha.Cells(cells).Value = PublicVar.UsrSisbr;

            //validação sobre os checkbox conceção e revogação
            PublicVar.CaminhoArquivo = "";
            PublicVar.identificador = frm.TB_identifica.Text;

            

            if (frm.cb_concecao.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "Concessao " + PublicVar.identificador + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\Concessão\" + dataAtual;
                PublicVar.CaminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(PublicVar.CaminhoArquivo);
                
            }
            else if (frm.cb_revoga.Checked == true)
            {
                string dataAtual = DateTime.Now.ToString("dd.MM");
                string nomeArquivo = "Revogação " + PublicVar.identificador + ".xlsx";
                string caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\revogação\" + dataAtual;
                PublicVar.CaminhoArquivo = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(PublicVar.CaminhoArquivo);
            }

        }
public static void LimpaSelecao(Frm_inicio frm)
        {
            frm.cb_revoga.Checked = false;
            frm.cb_concecao.Checked = false;
            frm.TB_name.Clear();
            frm.TB_base.Clear();

            
        }


    }
}
