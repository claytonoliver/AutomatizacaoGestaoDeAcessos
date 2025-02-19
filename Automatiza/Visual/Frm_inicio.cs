using Automatiza.Controle;
using System.Text;

namespace Automatiza
{
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void revogaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_inicio frm = new Frm_inicio();
            frm.TopLevel = false; // Define o formulário como um controle não-top-level
            frm.FormBorderStyle = FormBorderStyle.None; // Remove a borda do formulário
            frm.Dock = DockStyle.Fill; // Preenche o painel principal com o formulário
            pnl_principal.Controls.Clear(); // Limpa quaisquer controles existentes no painel
            pnl_principal.Controls.Add(frm); // Adiciona o formulário ao painel
            frm.Show();
        }

        private void novaPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaPlanilha frmn = new novaPlanilha();
            frmn.Show();
        }

        //Ação de clicar
        public void BTN_start_Click_1(object sender, EventArgs e)
        {

            progressBar.Value = 0;

            EnviaMensagem.EnviaMensagemTeams(this);
            progressBar.Value += 20;

            ControleInicio.ValidaOpcoes(this);
            progressBar.Value += 20;

            ControleInicio.CriaPlanilha(this);
            progressBar.Value += 20;

            ControleInicio.LimpaSelecao(this);
            progressBar.Value += 20;

            //ScrappingWeb.Scrapping();
            progressBar.Value += 20;


            TbAmostra.Text = Clipboard.GetText();

            // Reset the progress bar to 0 after completing all steps
            progressBar.Value = 0;



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

        private void substituiçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_substituicao frm = new frm_substituicao();
            frm.TopLevel = false; // Define o formulário como um controle não-top-level
            frm.FormBorderStyle = FormBorderStyle.None; // Remove a borda do formulário
            frm.Dock = DockStyle.Fill; // Preenche o painel principal com o formulário
            pnl_principal.Controls.Clear(); // Limpa quaisquer controles existentes no painel
            pnl_principal.Controls.Add(frm); // Adiciona o formulário ao painel
            frm.Show();
        }

        private void Send_Click(object sender, EventArgs e)
        {


            string webhookUrl = "https://cocred.webhook.office.com/webhookb2/4751af8d-bcd9-4825-9fc0-a902e542538a@7ec496a7-d14b-4f3b-a48c-8b7478b1e3e6/IncomingWebhook/83e006a7f9da4f40aee0d245a7bfaad3/5202d1a9-ced3-4964-8081-7d0305fcf7b8";
            string message = "Aprovar grupos do usuário (a): " + TB_name.Text + " conforme - " + TB_identifica.Text;
            bool mensagemEnviada = false;


            while (!mensagemEnviada)
            {
                using (HttpClient client = new HttpClient())
                {
                    var jsonPayload = "{\"text\": \"" + message + "\"}";
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(webhookUrl, content).Result;


                    if (response.IsSuccessStatusCode)
                    {

                        mensagemEnviada = true;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao enviar mensagem: " + response.StatusCode);
                    }
                }

                if (!mensagemEnviada)
                {
                    // Aguardar 60 segundos antes de reenviar a mensagem
                    Thread.Sleep(60000);
                }
            }
            TB_identifica.Clear();
            TB_name.Clear();

        }

        private void SelectBase_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectBase.Checked == true)
            {
                LB_base.Visible = 
                TB_base.Visible = true;

            }
            else
            {
                LB_base.Visible = 
                TB_base.Visible = false;
            }
        }

        private void novaPlanilhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            novaPlanilha frmn = new novaPlanilha();
            frmn.Show();
        }
    }
}