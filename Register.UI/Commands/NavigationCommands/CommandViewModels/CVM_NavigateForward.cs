using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.CommandViewModels
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