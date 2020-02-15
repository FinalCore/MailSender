using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities.Base;
using System.ComponentModel;

namespace MailSender.lib.Entities
{
    public class Recipient : PersonEntity, IDataErrorInfo
    {

        public override string Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
            }
        }

        string IDataErrorInfo.Error => null;

        string IDataErrorInfo.this[string PropertyName]
        {
            get
            {
                switch (PropertyName)
                {
                    default: return null;
                    case nameof(Name):
                        var name = Name;
                        if (name is null) return "пустая ссылка на имя";
                        if (name.Length < 2) return "длина имени должна быть больше 2 символов";
                        if (name.Length > 20) return "длина имени не должна превышать 20 символов";
                        return null;                          
                }
            }
        }

        public Recipient(int id, string name, string address) : base(id, name, address)
        {

        }

        public override string ToString()
        {
            return $"{this.Name}   {this.Address}";
        }
    }
}
