using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailSender.lib.Services.InMemory;

namespace MailSender.lib.Tests.Services.InMemory
{
    [TestClass]
    public class RecipientsStoreInMemoryTests
    {
        /// <summary>
        /// Метод, проверяющий будет ли выбрасываться исключение в случае когда создаваемый получатель имеет значение null
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Create_throw_ArgumentNullException()
        {
            var store = new RecipientsStoreInMemory();
            store.Create(null);
        }
        
        [TestMethod]
        public void Create_throw_ArgumentNullException_2()
        {
            var store = new RecipientsStoreInMemory();
            Assert.ThrowsException<ArgumentNullException>(() => store.Create(null));
        }
    }
}
