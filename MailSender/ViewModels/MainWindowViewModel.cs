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
        private readonly RecipientsManager recipientsManager;
        #endregion
        //public RecipientsManager RecipientsManager;

        public ObservableCollection<Recipient> recipients;
       
        public ObservableCollection<Recipient> Recipients
        {
            get => recipients;
            set => Set(ref recipients, value, "Recipients");
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
        public MainWindowViewModel(RecipientsManager recipientsManager)
        {
            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute);
            SaveRecipientChangesCommand = new RelayCommand<Recipient>(OnSavedRecipientChangesCommandExecuted, CanSaveRecipientsChangesCommandExecute);
            this.recipientsManager = recipientsManager;
            Recipients = new ObservableCollection<Recipient>(recipientsManager.GetAll());
        }

        private bool CanLoadRecipientsDataCommandExecute() => true;
        private void OnLoadRecipientsDataCommandExecuted()
        {
            Recipients = new ObservableCollection<Recipient>(recipientsManager.GetAll());
        }

        private bool CanSaveRecipientsChangesCommandExecute(Recipient recipient) => recipient != null;
        private void OnSavedRecipientChangesCommandExecuted(Recipient recipient)
        {
            recipientsManager.Edit(recipient);
            recipientsManager.SaveChanges();
        }
    }
}
