namespace Register.UI.Commands
{
    public class CloseCommandVM : UICommand
    {
        public CloseCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DisplayName = "X";
            WorkspaceOwner = workspaceOwner;
            DoExecute = o => WorkspaceOwner.RemoveCurrentWorkspace();
            DoCanExecuteCheck = () => WorkspaceOwner.HasWorkspaces;
        }

        public IWorkspaceOwner WorkspaceOwner { get; set; }
        public string DisplayName { get; set; }
    }
}