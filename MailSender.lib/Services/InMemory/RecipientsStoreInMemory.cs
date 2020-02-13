using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using MailSender.lib.Entities;
using MailSender.lib.Data;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services
{
    //Класс, определяющий место хранения данных для класса RecipientManager
   public class RecipientsStoreInMemory : IRecipientStore
    {
        public IEnumerable<Recipient> GetAll() => TestData.Recepients;

        public Recipient GetById(int id) => TestData.Recepients.FirstOrDefault(r => r.ID == id);

        public int Create(Recipient recipient)
        {
            if (TestData.Recepients.Contains(recipient)) return recipient.ID;
            else recipient.ID = TestData.Recepients.Count == 0 ? 1 : TestData.Recepients.Max(r => r.ID) + 1;
            TestData.Recepients.Add(recipient);
            return recipient.ID;
        }
        
        public void Edit(int id, Recipient recipient) 
        {
            var db_recipient = GetById(id);
            if (db_recipient is null) return;

            db_recipient.Name = recipient.Name;
            db_recipient.Address = recipient.Address;
        }

        public Recipient Remove(int id)
        {
            var db_recipient = GetById(id);
            if (db_recipient != null)
                TestData.Recepients.Remove(db_recipient);
            return db_recipient;
        }

        public void SaveChanges() 
        {
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище получателей");
        }
    }
}
