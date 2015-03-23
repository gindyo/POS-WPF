using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.ComandViewModels
{
    public class NavigateToHomeCommandVM : HeaderLinkCommand
    {
        public NavigateToHomeCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }
    }
}