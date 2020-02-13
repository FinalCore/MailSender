﻿using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Класс, описывающий отправителя
    /// </summary>
    public class Sender : NamedEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Sender(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
