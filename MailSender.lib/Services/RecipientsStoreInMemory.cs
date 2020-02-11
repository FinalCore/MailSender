using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;
using MailSender.lib.Data;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services
{
    //Класс, определяющий место хранения данных для класса RecipientManager
   public class RecipientsStoreInMemory : IRecipientsStore
    {
        public IEnumerable<Recipient> Get() => TestData.Recepients;
        public void Add(Recipient newRecipient) { }

        public void Edit(Recipient recepient) { }

        public void SaveChanges() { }
    }
}
