using System.Collections.Generic;
using Interfaces.Commands;
using Interfaces.VMBased;

namespace Register.UI.Interfaces.Commands.CommandContexts
{
    public interface IHeaderCommandContext : ICommandContext
    {
        IWorkspace CurrentWorkspace { get; }
        List<IUICommand> NavigationLinks { get; set; }
        bool HasWorkspaces { get; }
        void RemoveCurrentWorkspace();
        void GoToPreviousWorkspace();
        void GoToNextWorkspace();
        void AddWorkspace(IWorkspace workspace);
    }
}