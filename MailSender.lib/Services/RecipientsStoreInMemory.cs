using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;
using MailSender.lib.Data;

namespace MailSender.lib.Services
{
    //Класс, определяющий место хранения данных для класса RecipientManager
   public class RecipientsStoreInMemory
    {
        public IEnumerable<Recipient> Get() => TestData.Recepients;
    }
}
