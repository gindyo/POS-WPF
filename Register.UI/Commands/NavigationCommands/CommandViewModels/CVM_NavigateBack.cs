namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateBackCommandVM : HistoryCommandVM
    {
        public NavigateBackCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        protected override void NextWorkspace()
        {
            WorkspaceOwner.GoToPreviousWorkspace();
        }
    }
}