using Interfaces.VMBased;
using Register.UI.BaseUI.Implementations;

namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderLinkCommand : UICommand
    {
        protected readonly IWorkspaceOwner WorkspaceOwner;

        public HeaderLinkCommand(IWorkspaceOwner workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            DoCanExecuteCheck = () => true;
        }

        public string DisplayName { get; set; }
    }
}