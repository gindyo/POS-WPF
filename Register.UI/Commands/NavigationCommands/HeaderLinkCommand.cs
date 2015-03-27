namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderLinkCommand : UICommand
    {
        protected readonly IWorkspaceOwner WorkspaceOwner;

        public HeaderLinkCommand(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            DoCanExecuteCheck = () => true;
        }

        public string DisplayName { get; set; }
    }
}