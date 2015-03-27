using Register.UI.Home;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCmd : HeaderLinkCommand
    {
        public NavigateToHomeCmd(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DisplayName = "Home";
            DoExecute = o => WorkspaceOwner.AddWorkspace(new HomeVM());
        }
    }
}