using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    public class MailingList : NamedEntity
    {
        public ICollection<Recipient> Recipient { get; set; } = new List<Recipient>();

        public MailingList(int id, string name) : base(id, name)
        {

        }

    }
}
