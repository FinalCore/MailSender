using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;
using System.ComponentModel;

namespace MailSender.lib.Entities
{
    public class Recipient : PersonEntity/*, IDataErrorInfo*/
    {
        public override string Name 
        {
            get => base.Name;
            set
            {

            }
        }

        //public string Error => null;

        //public string this[string PropertyName]
        //{
        //    get 
        //    {

        //    }     
        //}
        

        public Recipient(int id, string name, string address)
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
