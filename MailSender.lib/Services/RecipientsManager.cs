using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;
 MVVM_pattern_self-studying
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
            return recipientsStore.Get();
        }

        // Методы для манипуляирования получателями (CRUD)


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
            

 MVVM_pattern_self-studying

        public void Edit(Recipient recepient)
        {

        }

        public void SaveChanges() { }


    }
}
