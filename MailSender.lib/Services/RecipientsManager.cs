using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services
{
    //Класс, отвечающий за обработку данных, касающихся получателей писем
   public class RecipientsManager
    {
        private RecipientsStoreInMemory recipientsStore;
        //Конcтруктор, с указанием места хранения данных для класса RecipientManager
        public RecipientsManager(RecipientsStoreInMemory recipientsStore)
        {
            this.recipientsStore = recipientsStore;
        }

        /// <summary>
        /// Метод, возвращающий всех получателей
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Recipient> GetAll()
        {
            return recipientsStore.Get();
        }

        // Методы для манипуляирования получателями (CRUD)
        public void Add(Recipient newRecipient)
        {

        }

        public void Edit(Recipient recepient)
        {

        }

        public void SaveChanges() { }

    }
}
