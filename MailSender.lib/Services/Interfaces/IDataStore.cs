using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services.Interfaces
{
    public interface IDataStore<T>
    {
        IEnumerable<T> GetAll();

        /// <summary> Получить объект по идентификатору </summary>
        /// <param name="id">Числовой идентификатор объекта в хранилище</param>
        /// <returns></returns>
        T GetById(int id); 

        int Create(T newT);

        void Edit(int id, T item);

        T Remove(int id);

        void SaveChanges();
    }
}
