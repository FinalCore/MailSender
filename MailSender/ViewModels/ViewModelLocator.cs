using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;
using MailSender.lib.Services.InMemory;


namespace MailSender.ViewModels
{
    //Класс, реализующий инверсию управления и внедрение зависимостей
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //Регистрируем все созданные модели и классы, отвечающие за бизнес-логику в контейнере сервисов через ViewModelLocator
            SimpleIoc.Default.Register<MainWindowViewModel>();
            //Отедельные классы бизнес-логики регистрируются через интерфейсы. Например, 
            SimpleIoc.Default.Register<IRecipientsManager, RecipientsManager>();
            SimpleIoc.Default.Register<ISendersStore, SendersStoreInMemory>();
            SimpleIoc.Default.Register<IServersStore, ServersStoreInMemory>();
            SimpleIoc.Default.Register<IMailsStore, MailsStoreInMemory>();
        }

        // Свойство, генерирующее одну из зарегистрированных моделей представления (в данном случае MainWindowViewModel)
        // через конструктор класса соответствующей модели. Для этого все типы, необходимые для создания экземпляра класса
        // MainWindowViewModel (в данном случае IRecipientsManager и IRecipientsStore) должны быть также зарегистрированы в контейнере сервисов 
        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();


    }
}
