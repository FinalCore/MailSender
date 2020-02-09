using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;

namespace MailSender.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //Регистрируем все созданные модели и классы, отвечающие за бизнес-логику в контейнере сервисов через ViewModelLocator
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<RecipientsManager>();
            SimpleIoc.Default.Register<RecipientsStoreInMemory>();
        }

        //не понял, за что отвечает данное свойство
        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

    }
}
