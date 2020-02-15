using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    public class Mail : BaseEntity
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public ICollection<MailAttachment> Attachments { get; set; } = new List<MailAttachment>();

        public Mail(int id, string subject, string body): base (id)
        {
            Subject = subject;
            Body = body;
        }
    }
}
