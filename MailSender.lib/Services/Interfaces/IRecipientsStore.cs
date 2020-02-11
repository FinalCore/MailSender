using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsStore
    {
        IEnumerable<Recipient> Get();

        // Методы для манипуляирования получателями (CRUD)
        void Add(Recipient newRecipient);

        void Edit(Recipient recepient);

        void SaveChanges();
    }
}
