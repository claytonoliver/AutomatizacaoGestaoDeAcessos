using Automatiza.Model;
using System.Text;

namespace Automatiza.Services
{
    public class EnviaMensagemService
    {
        public EnviaMensagemService(UsuarioModel usuario)
        {
            string webhookUrl = ParametroSistema.Url_Webhook;
            string message = "Aprovar grupos do usuário (a): " + usuario.UsuarioSisbr + " conforme - " + usuario.NomeIdentificador;
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
            }
        }
    }
}

