﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities.Base
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public BaseEntity(int id)
        {
            ID = id;
        }
    }
}
