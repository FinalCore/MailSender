using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary> Задача планировщика </summary>
    public class SchedulerTask : BaseEntity
    {
        /// <summary> Время выполнения задачи </summary>
        public DateTime Time { get; set; }
        /// <summary> Постановщик задачи </summary>
        public Sender Sender { get; set; }
        public MailingList Recipient { get; set; }
        public Server Server { get; set; }
        public Mail Mail { get; set; }
    }
}
