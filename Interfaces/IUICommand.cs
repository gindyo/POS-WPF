using System;
using System.Windows.Input;

namespace Interfaces
{
    public interface IUICommand : ICommand
    {
        event Action Executed;
    }
}