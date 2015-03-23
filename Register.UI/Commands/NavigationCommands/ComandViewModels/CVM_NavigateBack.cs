using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.ComandViewModels
{
    public class NavigateBackCommandVM : HistoryCommandVM
    {
        public NavigateBackCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        public override IWorkspace NextWorkspace()
        {
            int currentWorkspaceIndex = WorkspaceOwner.Workspaces.IndexOf(WorkspaceOwner.CurrentView);
            if (currentWorkspaceIndex <= 0)
                return null;
            return WorkspaceOwner.Workspaces[currentWorkspaceIndex - 1];
        }
    }
}