using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCommandVM : HeaderLinkCommand
    {
        public NavigateToHomeCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }
    }
}