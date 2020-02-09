using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services
{
    public class RecipientsManager
    {
        private RecipientStoreInMemory store;
        public RecipientsManager(RecipientStoreInMemory store)
        {
            this.store = store;
        }

        public IEnumerable<Recipient> GetAll()
        {
            return store.Get();
        }

        public void Add(Recipient newRecipient)
        {

        }

        public void Edit(Recipient recipient)
        {
            store.Edit(recipient.ID, recipient);
        }

        public void SaveChanges() { }
    }
}
