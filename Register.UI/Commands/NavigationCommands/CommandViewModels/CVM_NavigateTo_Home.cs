using Interfaces;
using Register.UI.MainWindow;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCommandVM : HeaderLinkCommand
    {
        public NavigateToHomeCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DisplayName = "Home";
            DoExecute = () => WorkspaceOwner.Workspaces.AddWorkspace(new HomeScreenVM());
        }
        
    }
}