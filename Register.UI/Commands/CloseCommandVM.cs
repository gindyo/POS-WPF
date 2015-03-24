using Interfaces.VMBased;
using Register.UI.BaseUI.Implementations;

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