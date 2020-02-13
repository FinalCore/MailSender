using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Entities.Base;
using System.Linq;

namespace MailSender.lib.Services.InMemory
{
    public abstract class DataStoreInMemory<T> : IDataStore<T> where T : BaseEntity
    {
        private readonly List<T> items;

        protected DataStoreInMemory(List<T> Items = null) => items = Items ?? new List<T>();

     
        public int Create(T newT)
        {
            if (items.Contains(newT)) return newT.ID;
            else newT.ID = items.Count == 0 ? 1 : items.Max(r => r.ID) + 1;
            items.Add(newT);
            return newT.ID; 
        }

        /// <summary>
        /// Каждый производный класс будет реализовывать данный метод по-своему потому что у всех - свои поля
        /// </summary>
        /// <param name="id"></param>
        /// <param name="item"></param>
        public abstract void Edit(int id, T item);
        

        public IEnumerable<T> GetAll() => items;


        public T GetById(int id) => items.FirstOrDefault(items => items.ID == id);
        public T Remove(int id)
        {
            var item = GetById(id);
            if (items != null)
                items.Remove(item);
            return item;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище {0}", typeof(T));
        }
    }
}
