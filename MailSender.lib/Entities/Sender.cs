using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Класс, описывающий отправителя
    /// </summary>
    public class Sender : PersonEntity
    {
        public Sender(int id, string name, string address) : base(id, name, address)
        {
        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
