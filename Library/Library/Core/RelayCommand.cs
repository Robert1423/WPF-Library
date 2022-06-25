using System;
using System.Windows.Input;

namespace Library.Core
{
    class RelayCommand : ICommand
    {
        //Klasa do sterowania wywołaniami komend z poziomu UI
        private Action<object> _execute;//Zmienna na funkcje void
        private Func<object, bool> _canExecute;//zmienna funkcje zwracającą wartość


        public event EventHandler CanExecuteChanged //sterowanie komendami
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute= execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) //wywołanie funkcji
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter) //wywołanie funkcji void
        {
            _execute(parameter);
        }
    }
}
