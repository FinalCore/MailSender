using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsStore
    {
        IEnumerable<Recipient> GetAll();

        Recipient GetById(int id); 

        int Create(Recipient newRecipient);

        void Edit(int id, Recipient recepient);

        Recipient Remove(int id);

        void SaveChanges();
    }
}
