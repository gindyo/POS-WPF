using System;
using Interfaces.Commands;

namespace Register.UI.BaseUI.Implementations
{
    public class UICommand : IUICommand
    {
        protected Func<bool> DoCanExecuteCheck;
        protected Action DoExecute;

        public bool CanExecute(object parameter)
        {
            if (DoCanExecuteCheck != null)
                return DoCanExecuteCheck();
            return true;
        }

        public void Execute(object parameter)
        {
            if (DoExecute != null)
                DoExecute();
            Executed.Invoke();
        }

        public event EventHandler CanExecuteChanged;
        public event Action Executed;
    }
}