﻿using System;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.Utility
{
    public class CustomCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            bool b = _canExecute == null ? true : _canExecute(parameter);
            return b;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}