using System;
using System.Windows.Input;

namespace LoginApp.ViewModel
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<Object,bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<Object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
       
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            else
                return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);

        }
    }
}