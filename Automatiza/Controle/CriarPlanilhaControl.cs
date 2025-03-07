using Automatiza.Controle.VariaveisPublicas;
using Automatiza.Enum;
using Automatiza.Model;
using System.Text.RegularExpressions;

namespace Automatiza.Controle
{
    public class CriarPlanilhaControl
    {

        private ArquivoModel pathCaminho = new ArquivoModel();
        private UsuarioModel _Usuario;
        private bool _concederAcessos;

        public CriarPlanilhaControl(UsuarioModel usuario, bool concederAcessos)
        {
            _Usuario = usuario;
            _concederAcessos = concederAcessos;
        }


        private void DefinePlanilhaDeAcessoBase()
        {
            if (_concederAcessos)
            {
                switch (_Usuario.CargoAcesso)
                {
                    case CargosEnum.AssistenteAtendimento:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Assistente de atendimento.xlsx";
                        break;

                    case CargosEnum.CaixaTesoureiro:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Caixa Tesoureiro.xlsx";
                        break;

                    case CargosEnum.Caixa:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Caixa.xlsx";
                        break;

                    case CargosEnum.GerentePA:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Gerente PA.xlsx";
                        break;

                    case CargosEnum.GerenteContas:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Gerente de Contas.xlsx";
                        break;

                    case CargosEnum.GerenteAdministrativo:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Gerente ADM.xlsx";
                        break;

                    case CargosEnum.Estagiario:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}Estagiário.xlsx";
                        break;

                    case CargosEnum.TesoureitoXGerenteAdm:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}substituição\Caixa TesoureiroXGerente Administrativo.xlsx";
                        break;

                    case CargosEnum.GerenteContasXGerentePA:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}substituição\Gerente de ContasXGerente de PA.xlsx";
                        break;

                    case CargosEnum.CaixaXTesoureiro:
                        pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseConcecao}substituição\Caixa X Caixa Tesoureiro.xlsx";
                        break;
                }
                return;
            }

            switch (_Usuario.CargoAcesso)
            {
                case CargosEnum.AssistenteAtendimento:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Assistente de atendimento.xlsx";
                    break;

                case CargosEnum.CaixaTesoureiro:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Caixa Tesoureiro.xlsx";
                    break;

                case CargosEnum.Caixa:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Caixa.xlsx";
                    break;

                case CargosEnum.GerentePA:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Gerente PA.xlsx";
                    break;

                case CargosEnum.GerenteContas:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Gerente de Contas.xlsx";
                    break;

                case CargosEnum.GerenteAdministrativo:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Gerente ADM.xlsx";
                    break;

                case CargosEnum.Estagiario:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}Estagiário.xlsx";
                    break;

                case CargosEnum.TesoureitoXGerenteAdm:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}substituição\Caixa TesoureiroXGerente Administrativo.xlsx";
                    break;

                case CargosEnum.GerenteContasXGerentePA:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}substituição\Gerente de ContasXGerente de PA.xlsx";
                    break;

                case CargosEnum.CaixaXTesoureiro:
                    pathCaminho.PathArquivo = @$"{ParametroSistema.PathPlanilhasBaseRevogacao}substituição\Caixa X Caixa Tesoureiro.xlsx";
                    break;
            }
        }


        private void ValidaAlteracaoDeBase()
        {
            string basePaAlterada;

            if (!_Usuario.AlterarBasePA)
            {
                MatchCollection matches = Regex.Matches(_Usuario.BasePA, @"\d+");
                basePaAlterada = matches[matches.Count - 1].Value;

                if (basePaAlterada.Length > 2)
                {
                    MessageBox.Show("Não pode!");
                }

                _Usuario.BasePA = basePaAlterada;

                return;
            }
        }

        public void CriaPlanilha()
        {

            ValidaAlteracaoDeBase();
            DefinePlanilhaDeAcessoBase();

            //Vai opegar o caminho com base a planilha
            var xls = new ClosedXML.Excel.XLWorkbook(pathCaminho.PathArquivo);

            //pega o nome da sheet
            var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();
            var celulasBasePA = string.Empty;
            var celulasUsuarioSisbr = string.Empty;

            switch (_Usuario.CargoAcesso)
            {
                case CargosEnum.AssistenteAtendimento:
                    celulasBasePA = ParametroSistema.CelulasAssistenAtendimento;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.CaixaTesoureiro:
                    celulasBasePA = ParametroSistema.CelulasCaixaTesoureiro;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.Caixa:
                    celulasBasePA = ParametroSistema.CelulasCaixa;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.GerentePA:
                    celulasBasePA = ParametroSistema.CelulasGerentePA;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.GerenteContas:
                    celulasBasePA = ParametroSistema.CelulasGerenteContas;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.GerenteAdministrativo:
                    celulasBasePA = ParametroSistema.CelulasGerenteAdministrativo;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.Estagiario:
                    celulasBasePA = ParametroSistema.CelulasEstagiario;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.TesoureitoXGerenteAdm:
                    celulasBasePA = ParametroSistema.CelulasTesoureitoXGerenteAdm;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.GerenteContasXGerentePA:
                    celulasBasePA = ParametroSistema.CelulasGerenteContasXGerentePA;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;

                case CargosEnum.CaixaXTesoureiro:
                    celulasBasePA = ParametroSistema.CelulasCaixaXTesoureiro;
                    planilha.Cells(celulasBasePA).Value = _Usuario.BasePA;
                    break;
            }

            var FimDadosPlanilhaPA = celulasBasePA.Trim().Split(':');

            celulasUsuarioSisbr = "D7:" + FimDadosPlanilhaPA[1].Replace("C","D");


            planilha.Cells(celulasUsuarioSisbr).Value = _Usuario.UsuarioSisbr;

            string nomeArquivo = string.Empty;
            string caminhoPasta = string.Empty;
            string PathBaseSaveSheet = string.Empty;
            //Se For conceção
            if (_concederAcessos)
            {
                nomeArquivo =  _Usuario.NomeIdentificador + ".xlsx";
                caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\Concessão\" + DateTime.Now.ToString("dd.MM");
                PathBaseSaveSheet = caminhoPasta + "\\" + nomeArquivo;

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }
                xls.SaveAs(PathBaseSaveSheet);

                return;
            }
            //Se revogação
            nomeArquivo = PublicVar.identificador + ".xlsx";
            caminhoPasta = @"Z:\Suporte\- GESTÃO DE ACESSOS\CCS-grupos-fluxos\revogação\" + DateTime.Now.ToString("dd.MM");
            PathBaseSaveSheet = caminhoPasta + "\\" + nomeArquivo;

            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }
            xls.SaveAs(PathBaseSaveSheet);

        }
    }
}
