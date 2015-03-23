using Register.UI.BaseUI.Implementations;
using Register.UI.BaseUI.Interfaces;

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