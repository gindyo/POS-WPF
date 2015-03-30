using Interfaces.VMBased;

namespace Register.UI.Interfaces.Commands.CommandContexts
{
    public interface IHeaderCommandContext : ICommandContext
    {
        IWorkspace CurrentWorkspace { get; }
        bool HasWorkspaces { get; }
        void RemoveCurrentWorkspace();
        void GoToPreviousWorkspace();
        void GoToNextWorkspace();
        void AddWorkspace(IWorkspace workspace);
    }
}