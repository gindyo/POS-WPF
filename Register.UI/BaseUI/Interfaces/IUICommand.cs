using System;
using System.Windows.Input;

namespace Register.UI.BaseUI.Interfaces
{
    public interface IUICommand : ICommand
    {
        event Action Executed;
    }
}