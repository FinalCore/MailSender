using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows;

namespace TestWPF
{
    class EmailSendServiceClass
    {
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public string To { get; set; }

        public readonly string from;
        
        public EmailSendServiceClass()  
        {
            from = "rimedheart@yandex.ru";            
        }
             
        public void SendMail(string userName, SecureString userPassword)
        {
            try
            {
                using (var message = new MailMessage(this.from, this.To))
                {
                    message.Subject = this.MessageSubject;
                    message.Body = this.MessageBody;


                    using (var client = new SmtpClient(ServerData.serverAddress, ServerData.serverPort))
                    {
                        client.EnableSsl = true;

                        client.Credentials = new NetworkCredential(userName, userPassword);

                        client.Send(message);
                    }
                }
                MessageBox.Show("Почта отправлена!", "Ура!!!",
                          MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }       
    }
}