using System;
using System.Windows.Input;

namespace Interfaces.Commands
{
    public interface IUICommand : ICommand
    {
        string DisplayName { get; set; }
        event Action Executed;
    }
}