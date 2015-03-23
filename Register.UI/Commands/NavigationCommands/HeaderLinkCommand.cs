using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands
{
    public class HeaderLinkCommand : UICommand
    {
        protected readonly IWorkspaceOwner WorkspaceOwner;

        public HeaderLinkCommand(IWorkspaceOwner workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            DoCanExecuteCheck = () => true;
        }
    }
}