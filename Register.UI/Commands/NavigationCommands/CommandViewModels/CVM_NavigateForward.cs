namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateForwardCommandVM : HistoryCommandVM
    {
        public NavigateForwardCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        protected override void NextWorkspace()
        {
            WorkspaceOwner.GoToNextWorkspace();
        }
    }
}