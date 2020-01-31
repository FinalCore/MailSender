using System;
using System.Net;
using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender = "sender@server.ru";
            string recepient = "recepient@server.ru";
            System.Net.Mail.MailMessage msg = new MailMessage(sender, recepient);
            msg.Subject = "Тема сообщения";
            msg.Body = "Текст сообщения";
            msg.IsBodyHtml = false;
            System.Net.Mail.SmtpClient client = new SmtpClient("smtp.yandex.ru", 25);
            client.EnableSsl = true;
            string UserName = Console.ReadLine();
            string Password = Console.ReadLine();
            client.Credentials = new NetworkCredential(UserName, Password);
            client.Send(msg);
            
        }
    }
}
