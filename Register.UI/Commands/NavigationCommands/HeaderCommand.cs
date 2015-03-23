using System.Linq;
using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands
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