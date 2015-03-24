using System.Collections.Generic;

namespace Interfaces
{
    public interface IWorkspaceOwner
    {
        IWorkspaces Workspaces { get; }
        IWorkspace CurrentWorkspace { get; }
        List<IUICommand> NavigationLinks { get; set; }
        bool HasWorkspaces();
        void RemoveCurrentWorkspace();
    }
}