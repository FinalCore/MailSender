using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Класс, описывающий сервер 
    /// </summary>
    public class Server : NamedEntity
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; } = true;
        public string Login { get; set; }
        public string Password { get; set; }

        public Server(int id, string name, string address, int port, string login, string password)
        {
            ID = id;
            Name = name;
            Address = address;
            Port = port;
            Login = login;
            Password = password;
        }
    }
}
