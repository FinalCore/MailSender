using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    /// <summary> Хранилище объектов в памяти </summary>
    /// <typeparam name="T"> Тип хранимого объекта </typeparam>
    public interface IDataStore<T>
    {
        /// <summary> Получить все объекты </summary>
        /// <returns>Перечисление объектов</returns>
        IEnumerable<T> GetAll();

        T GetById(int id); 

        int Create(T newRecipient);

        void Edit(int id, T recepient);

        T Remove(int id);

        void SaveChanges();
    } 
}
