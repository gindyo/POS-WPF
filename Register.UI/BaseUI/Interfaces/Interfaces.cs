using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Register.BaseUI.Interfaces
{
    public interface IWorkspaceOwner
    {
        IWorkspaces Workspaces { get; }
        IWorkspace CurrentView { get; set; }
        List<IUICommand> NavigationLinks { get; set; }
        void OnWorkspaceRequestClose();
    }

    public interface IUICommand : ICommand
    {
        event Action Executed;
    }

    public interface IWorkspaces : IList<IWorkspace>
    {
    }

    public interface IWorkspace
    {
        string DisplayName { get; set; }
    }
}