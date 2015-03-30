using System;
using Interfaces.Commands;

namespace Register.UI.Commands
{
    public abstract class CommandVM : IUICommand
    {
        protected Func<bool> DoCanExecuteCheck;
        protected Action<object> DoExecute;
        public string DisplayName { get; set; }

        public bool CanExecute(object parameter)
        {
            if (DoCanExecuteCheck != null)
                return DoCanExecuteCheck();
            return true;
        }

        public void Execute(object parameter)
        {
            if (DoExecute != null)
                DoExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
        public event Action Executed;
    }
}