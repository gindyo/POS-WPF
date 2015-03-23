using System.Linq;
using Register.UI.BaseUI.Implementations;
using Register.UI.BaseUI.Interfaces;

namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderCommand : UICommand
    {
        protected readonly IWorkspaceOwner WorkspaceOwner;

        public HeaderCommand(IWorkspaceOwner workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            DoCanExecuteCheck = () => WorkspaceOwner.Workspaces.Any();
        }
    }
}