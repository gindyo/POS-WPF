using System.Linq;
using Interfaces.VMBased;
using Register.UI.BaseUI.Implementations;

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