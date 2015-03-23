using Register.UI.BaseUI.Interfaces;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCommandVM : HeaderLinkCommand
    {
        public NavigateToHomeCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }
    }
}