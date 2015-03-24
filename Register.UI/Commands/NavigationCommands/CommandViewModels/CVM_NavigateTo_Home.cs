using Interfaces.VMBased;
using Register.UI.Home;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCommandVM : HeaderLinkCommand
    {
        public NavigateToHomeCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DisplayName = "Home";
            DoExecute = () => WorkspaceOwner.Workspaces.AddWorkspace(new HomeVM());
        }
    }
}