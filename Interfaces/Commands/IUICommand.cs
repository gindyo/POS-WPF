using System;
using System.Windows.Input;

namespace Interfaces.Commands
{
    public interface IUICommand : ICommand
    {
        event Action Executed;
    }
}