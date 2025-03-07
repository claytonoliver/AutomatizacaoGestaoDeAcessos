using Automatiza.Controle;
using Automatiza.Enum;
using Automatiza.Model;
using Automatiza.Services;

namespace Automatiza
{
    public partial class Frm_inicio : Form
    {

        private EnviaMensagemService _enviaMensagemService;
        private UsuarioModel _usuarioModel;

        public Frm_inicio()
        {
            
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            var lista = CargosEnum.GetValues(typeof(CargosEnum))
                .Cast<CargosEnum>()
                .Select(cargo => new
                {
                    Value = cargo,
                    Description = cargo.GetDescription()
                })
                .ToList();

            cb_cargoAcesso.DataSource = lista;
            cb_cargoAcesso.DisplayMember = "Description";
            cb_cargoAcesso.ValueMember = "Value";

            cb_cargoAcesso.SelectedIndex = 1;
        }

        private void novaPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaPlanilha frmn = new novaPlanilha();
            frmn.Show();
        }

        //Ação de clicar
        public void BTN_start_Click_1(object sender, EventArgs e)
        {
            //ControleInicio.CriaPlanilha(this);
            //progressBar.Value += 20;
        }

        private void cb_concecao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_concecao.Checked == true)
            {
                cb_revoga.Checked = false;
            }
        }

        private void cb_revoga_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_revoga.Checked == true)
            {
                cb_concecao.Checked = false;
            }
        }


        private void SelectBase_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AlteraBasePa.Checked == true)
            {
                tb_BasePA.Visible = true;

            }
            else
            {
                tb_BasePA.Visible = false;
            }
        }

        private void btnGerarPlanilha_Click(object sender, EventArgs e)
        {
            GerarListaUsuarios();
            GerarPlanilha();
            //_enviaMensagemService = new EnviaMensagemService(_usuarioModel);

        }

        private void GerarPlanilha()
        {
            CriarPlanilhaControl criarPlanilhaControl = new CriarPlanilhaControl(_usuarioModel, cb_concecao.Checked);
            criarPlanilhaControl.CriaPlanilha();
        }

        private void GerarListaUsuarios()
        {
            _usuarioModel = new UsuarioModel
            {
                UsuarioSisbr = tb_usuarioSisbr.Text,
                CargoAcesso = (CargosEnum)cb_cargoAcesso.SelectedValue,
                NomeIdentificador = TB_identifica.Text,
                BasePA = tb_BasePA.Text
            };

        }
    }
}