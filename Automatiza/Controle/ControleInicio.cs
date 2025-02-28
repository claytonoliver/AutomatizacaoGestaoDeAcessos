using Automatiza.Controle.VariaveisPublicas;
using System.Text.RegularExpressions;
using Excel = ClosedXML.Excel;

namespace Automatiza.Controle
{

    public class ControleInicio
    {

        public static void ValidaOpcoes(Frm_inicio frm)
        {

            
        }

        public static void DigitaBase(Frm_inicio frm)
        {


            if (frm.cb_AlteraBasePa.Checked == true)
            {

                frm.tb_BasePA.Visible = true;

            }
            else
            {

                frm.tb_BasePA.Visible = false;

            }
        }
        public static void CriaPlanilha(Frm_inicio frm)
        {

            PublicVar.UsrSisbr = frm.TB_name.Text;

            if (frm.cb_AlteraBasePa.Checked)
            {
                PublicVar.BasePA = frm.tb_BasePA.Text;
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
            frm.tb_BasePA.Clear();


        }


    }
}
