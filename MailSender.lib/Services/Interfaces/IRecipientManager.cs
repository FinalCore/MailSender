using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsManager
    {
        IEnumerable<Recipient> GetAll();

        // Методы для манипуляирования получателями (CRUD)
        void Add(Recipient newRecipient);

        void Edit(Recipient recepient);

        void SaveChanges();
    }    
}
