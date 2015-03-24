using Interfaces.VMBased;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateForwardCommandVM : HistoryCommandVM
    {
        public NavigateForwardCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        public override IWorkspace NextWorkspace()
        {
            return WorkspaceOwner.Workspaces.Next();
        }
    }
}