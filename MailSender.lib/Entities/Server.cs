using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Класс, описывающий сервер 
    /// </summary>
    public class Server
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; } = true;
        public string Login { get; set; }
        public string Password { get; set; }

        public Server(string name, string address, int port, string login, string password)
        {
            Name = name;
            Address = address;
            Port = port;
            Login = login;
            Password = password;
        }
    }
}
