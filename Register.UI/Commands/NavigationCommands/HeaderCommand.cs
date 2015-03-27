namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderCommand : UICommand
    {
        protected readonly IWorkspaceOwner WorkspaceOwner;

        public HeaderCommand(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            DoCanExecuteCheck = () => WorkspaceOwner.HasWorkspaces;
        }
    }
}