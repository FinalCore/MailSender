using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace MailSender.lib.MVVM
{
    public class LambdaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> commandAction;

        private Func<object, bool> canExecute;

        public LambdaCommand(Action<object> CommandAction, Func<object, bool> CanExecute = null)
        {
            commandAction = CommandAction;
            canExecute = CanExecute;
        }


        public bool CanExecute(object parameter)
        {
            if (canExecute?.Invoke(parameter) != null)
                return canExecute(parameter);
            else return true;
        }

        public void Execute(object parameter)
        {
            commandAction(parameter);
        }
    }
}
