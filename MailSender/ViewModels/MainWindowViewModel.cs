using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using MailSender.lib.Services;
using MailSender.lib.Entities;
using System.Collections.ObjectModel;

namespace MailSender.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string title = "Приложение для рассылки почты";
        private readonly RecipientsManager recipientsManager; 

        public string Title
        {
            get => title;
            set => Set(ref title, value);
        }

        private ObservableCollection<Recipient> recipients = new ObservableCollection<Recipient>();
        
        public ObservableCollection<Recipient> Recipients 
        { 
            get => recipients;
            set => Set(ref recipients, value);
        } 

        public MainWindowViewModel(RecipientsManager recipientsManager)
        {
            this.recipientsManager = recipientsManager;
            Recipients = new ObservableCollection<Recipient>(recipientsManager.GetAll());
        }

    }
}
