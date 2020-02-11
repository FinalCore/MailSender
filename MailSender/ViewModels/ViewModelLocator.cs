﻿using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
 MVVM_pattern_self-studying
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;


namespace MailSender.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
 MVVM_pattern_self-studying
            //Регистрируем все созданные модели и классы, отвечающие за бизнес-логику в контейнере сервисов через ViewModelLocator
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<IRecipientsManager, RecipientsManager>();
            SimpleIoc.Default.Register<IRecipientsStore, RecipientsStoreInMemory>();
        }

        //не понял, за что отвечает данное свойство
        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();


    }
}
