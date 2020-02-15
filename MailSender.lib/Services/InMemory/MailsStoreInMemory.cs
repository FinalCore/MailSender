using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using MailSender.lib.Entities;
using MailSender.lib.Data;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    public class MailsStoreInMemory : DataStoreInMemory<Mail>, IMailsStore
    {
        // Заполнение коллекции писем тестовыми данными
        private static List<Mail> mails;
        public static List<Mail> Mails
        {
            get => mails;
            set
            {
                for (int i = 1; i < 11; i++)
                    mails.Add(new Mail(i, $"Message {i}", $"Message body {i}"));
            }
        }
        
        public MailsStoreInMemory() : base(Mails)
        {

        }
        public override void Edit(int id, Mail mail)
        {
            var db_mail = GetById(id);
            if (db_mail is null) return;

            db_mail.Subject = mail.Subject;
            db_mail.Body = mail.Body;
        }
    }
}
