using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateBackCommandVM : HistoryCommandVM
    {
        public NavigateBackCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        public override IWorkspace NextWorkspace()
        {
            return WorkspaceOwner.Workspaces.Previous();
        }
    }
}