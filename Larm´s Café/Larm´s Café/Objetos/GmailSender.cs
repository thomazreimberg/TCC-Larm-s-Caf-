using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twilio;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Net;

namespace Larm_s_Café.Objetos
{
    class GmailSender
    {
                /// <summary>
        /// Função responsável por enviar um e-mail a partir da configuração feita na função ConfigurarCredenciais
        /// </summary>
        /// <param name="emailPara">E-mail para enviar a mensagem</param>
        /// <param name="assunto">Assunto do e-mail</param>
        /// <param name="mensagem">Mensagem do e-mail</param>
        public void Enviar(string emailPara, string assunto, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = "---";
                string senha = "---";


                // Configura Remetente, Destinatário
                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);


                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;


                // Configura os parâmetros do objeto SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);


                // Envia a mensagem
                smtp.Send(email);

            });
        }

        public void EnviarSMS(string telefonePara, string mensagem)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //+14156304449
            TwilioClient.Init("--", "--");
            
            var message = MessageResource.Create(
                new PhoneNumber(telefonePara),
                from: new PhoneNumber("+14156304449"),
                body: mensagem
            );
        }

        public void EnviarWhatsApp(string telPara, string mensagem)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //+14156304449
            TwilioClient.Init("--", "--");

            var message = MessageResource.Create(
                new PhoneNumber("whatsapp:" + telPara),
                from: new PhoneNumber("whatsapp:+14155238886"),
                body: mensagem
            );
        }//+5511994465801
    }
}
