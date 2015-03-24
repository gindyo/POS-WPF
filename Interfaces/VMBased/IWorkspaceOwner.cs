using System.Collections.Generic;
using Interfaces.Commands;
using Interfaces.VMBased.Collections;

namespace Interfaces.VMBased
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