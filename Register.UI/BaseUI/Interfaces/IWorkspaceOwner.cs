using System.Collections.Generic;

namespace Register.BaseUI.Interfaces
{
    public interface IWorkspaceOwner
    {
        IWorkspaces Workspaces { get; }
        IWorkspace CurrentWorkspace { get; set; }
        List<IUICommand> NavigationLinks { get; set; }
        bool HasWorkspaces();
        void RemoveCurrentWorkspace();
    }
}