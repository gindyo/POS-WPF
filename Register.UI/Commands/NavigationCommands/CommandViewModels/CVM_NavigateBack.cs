using Interfaces;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateBackCommandVM : HistoryCommandVM
    {
        public NavigateBackCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DoCanExecuteCheck = () => true;
            DoExecute = () => NextWorkspace();
        }

        public override IWorkspace NextWorkspace()
        {
            return WorkspaceOwner.Workspaces.Previous();
        }
    }
}