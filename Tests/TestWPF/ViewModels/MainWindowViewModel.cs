using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.MVVM;

namespace TestWPF.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string title = "Новое окно!";

        public string Title2
        {
            get => title;
            set => Set(ref title, value, Title2);
        }
            
            
    }
}
