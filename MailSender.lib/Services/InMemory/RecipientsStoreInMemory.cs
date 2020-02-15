using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using MailSender.lib.Entities;
using MailSender.lib.Data;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    //Класс, определяющий место хранения данных для класса RecipientManager
   public class RecipientsStoreInMemory : DataStoreInMemory<Recipient>, IRecipientsStore
    {
        public RecipientsStoreInMemory() : base(TestData.Recepients) { }
        public override void Edit(int id, Recipient recipient) 
        {
            var db_recipient = GetById(id);
            if (db_recipient is null) return;

            db_recipient.Name = recipient.Name;
            db_recipient.Address = recipient.Address;
        }              
    }  
}
