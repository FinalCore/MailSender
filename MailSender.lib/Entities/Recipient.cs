﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    public class Recipient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Recipient(int id, string name, string address)
        {
            Name = name;
            Address = address;
            ID = id;
        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
