using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services
{
    //Класс, отвечающий за обработку данных, касающихся получателей писем
   public class RecipientsManager : IRecipientsManager
    {
        private IRecipientsStore recipientsStore;
        //Конcтруктор, с указанием места хранения данных для класса RecipientManager
        public RecipientsManager(IRecipientsStore recipientsStore)
        {
            this.recipientsStore = recipientsStore;
        }

        /// <summary>
        /// Метод, возвращающий всех получателей
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> GetAll()
        {
            return recipientsStore.GetAll();
        }

        // Методы для манипуляирования получателями (CRUD)

        public void Add(Recipient newRecipient) { }

        public void Edit(Recipient recepient) { }

        public void SaveChanges() { }
    }
}
