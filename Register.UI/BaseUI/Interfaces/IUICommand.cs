using System;
using System.Windows.Input;

namespace Register.BaseUI.Interfaces
{
    public interface IUICommand : ICommand
    {
        event Action Executed;
    }
}