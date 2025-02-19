using Automatiza.Controle.VariaveisPublicas;
using System.Text;

namespace Automatiza.Controle
{
    public class EnviaMensagem
    {

        public static void EnviaMensagemTeams(Frm_inicio frm)
        {

            PublicVar.UsrSisbr = frm.TB_name.Text;
            PublicVar.identificador = frm.TB_identifica.Text;

            string webhookUrl = "https://cocred.webhook.office.com/webhookb2/4751af8d-bcd9-4825-9fc0-a902e542538a@7ec496a7-d14b-4f3b-a48c-8b7478b1e3e6/IncomingWebhook/83e006a7f9da4f40aee0d245a7bfaad3/5202d1a9-ced3-4964-8081-7d0305fcf7b8";
            string message = "Aprovar grupos do usuário (a): " + PublicVar.UsrSisbr + " conforme - " + PublicVar.identificador;
            bool mensagemEnviada = false;
            if (frm.CB_Aprova.Checked == true)
            {
            
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
                        Thread.Sleep(60000);
                    }
                }
            }
        }


    }

}

