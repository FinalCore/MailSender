using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.MVVM;

namespace TestWPF.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string title = "Новое окно...";
        private int rotationAngle = 40;

        public string Title
        {
            get => title;
            set => Set(ref title, value, Title);
        }

        public int RotationAngle
        {
            get => rotationAngle;
            set => Set(ref rotationAngle, value, "RotationAngle");
        }
            
            
    }
}
