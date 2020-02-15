using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;
using MailSender.lib.Entities;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.lib.Services.Interfaces;


namespace MailSender.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        

        //Тест работы модели представления на примере названия окна

        private string title = "Приложение для рассылки почты";
        public string Title
        {
            get => title;
            set => Set(ref title, value, "Title");
        }

        #region// Подключаем калссы, отвечающие за бизнес-логику приложения к модели представления главного окна (MainWindowViewModel)
        private readonly IRecipientsManager recipientsManager;
        private readonly ISendersStore sendersStore;
        private readonly IServersStore serversStore;
        private readonly IMailsStore mailsStore;
        #endregion
        //public RecipientsManager RecipientsManager;

        private ObservableCollection<Recipient> recipients;
       
        public ObservableCollection<Recipient> Recipients
        {
            get => recipients;
            set => Set(ref recipients, value, "Recipients");
        }
        
        private ObservableCollection<Sender> senders;
       
        public ObservableCollection<Sender> Senders
        {
            get => senders;
            set => Set(ref senders, value, "Senders");
        }

        private ObservableCollection<Server> servers;

        public ObservableCollection<Server> Servers
        {
            get => servers;
            set => Set(ref servers, value, "Servers");
        }

        private ObservableCollection<Mail> mails;

        public ObservableCollection<Mail> Mails
        {
            get => mails;
            set => Set(ref mails, value, "Mails");
        }

        private Recipient selectedRecipient;
        public Recipient SelectedRecipient
        {
            get => selectedRecipient;
            set => Set(ref selectedRecipient, value, "SelectedRecipient");
        }

        #region Команды
        public ICommand LoadRecipientsDataCommand { get; }
        public ICommand SaveRecipientChangesCommand { get; }

        #endregion

        // Определяем конструкторы класса
        //public MainWindowViewModel() { }

        /// <summary>
        /// Конструктор, с заполением поля recipients путем создания новой ObservableCollection и вызова метода GetAll для заполнения этой коллекции всеми имеющимися получателями
        /// </summary>
        /// <param name="recipientsManager"></param>
        /// Помимо получателей указываем в конструкторе все нужные нам в качестве зависимостей классы
        public MainWindowViewModel(IRecipientsManager recipientsManager, ISendersStore sendersStore, IServersStore serversStore, IMailsStore mailsStore)
        {
            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute);
            SaveRecipientChangesCommand = new RelayCommand<Recipient>(OnSavedRecipientChangesCommandExecuted, CanSaveRecipientsChangesCommandExecute);

            this.recipientsManager = recipientsManager;
            this.sendersStore = sendersStore;
            this.serversStore = serversStore;
            this.mailsStore = mailsStore;

            //Recipients = new ObservableCollection<Recipient>(recipientsManager.GetAll());
        }

        private bool CanLoadRecipientsDataCommandExecute() => true;
        private void OnLoadRecipientsDataCommandExecuted()
        {
            Recipients = new ObservableCollection<Recipient>(recipientsManager.GetAll());
            Senders = new ObservableCollection<Sender>(sendersStore.GetAll());
            Servers = new ObservableCollection<Server>(serversStore.GetAll());
            Mails = new ObservableCollection<Mail>(mailsStore.GetAll());
        }

        private bool CanSaveRecipientsChangesCommandExecute(Recipient recipient) => recipient != null;
        private void OnSavedRecipientChangesCommandExecuted(Recipient recipient)
        {
            recipientsManager.Edit(recipient);
            recipientsManager.SaveChanges();
        }

    }
}
