using Register.UI.BaseUI.Implementations;
using Register.UI.BaseUI.Interfaces;

namespace Register.UI.Commands
{
    public class CloseCommandVM : UICommand
    {
        public CloseCommandVM(IWorkspaceOwner workspaceOwner)
        {
            DisplayName = "X";
            WorkspaceOwner = workspaceOwner;
            DoExecute = () => WorkspaceOwner.RemoveCurrentWorkspace();
            DoCanExecuteCheck = () => WorkspaceOwner.HasWorkspaces();
        }

        public IWorkspaceOwner WorkspaceOwner { get; set; }
        public string DisplayName { get; set; }
    }
}