using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Класс, описывающий отправителя
    /// </summary>
    public class Sender
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Sender(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
