using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MailSender.lib.MVVM
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        // Объявляем событие, наступающее при изменении какого-либо свойства объекта "sender"
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод, вызывающий событие при изменении определенного свойства, имя которого передается в метод
        /// </summary>
        /// <param name="PropertyName"></param>
        protected virtual void OnPropertyChanged (string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Метод, изменяющий значение поля при изменении соответствующего свойства и вызывающий событие OnPropertyChanged в этом случае 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, string PropertyName)
        {
            if (Equals(field, value)) return false;
            else
            {
                field = value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }

    }
}
