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
        string messageSubject = $"Тестовое сообщение от {DateTime.Now}";
        string messageBody = $"Текст сообщения - {DateTime.Now}";

        public readonly string from;
        public readonly string to;
        public EmailSendServiceClass()  
        {
            from = "rimedheart@yandex.ru";
            to = "rimedheart@yandex.ru";
        }
             
        public void SendMail(string userName, SecureString userPassword)
        {
            try
            {
                using (var message = new MailMessage(this.from, this.to))
                {
                    message.Subject = this.messageSubject;
                    message.Body = this.messageBody;


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

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }       
    }
}