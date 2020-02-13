using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    public class Recipient : NamedEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Recipient(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
