using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities.Base
{
    public abstract class PersonEntity : NamedEntity
    {
        public string Address { get; set; }
        public PersonEntity(int id, string name, string address) : base(id, name)
        {
            Address = address;
        }
    }
}
