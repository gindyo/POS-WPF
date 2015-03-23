using Register.UI.BaseUI.Interfaces;
using Register.UI.ProductSearch;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    internal class NavigateToSearchProductVM : HeaderLinkCommand
    {
        public NavigateToSearchProductVM(IWorkspaceOwner wsOwner) : base(wsOwner)
        {
            DisplayName = "Product Search";
            DoCanExecuteCheck = () => true;
            DoExecute = Navigate;
        }

        private void Navigate()
        {
            WorkspaceOwner.Workspaces.AddWorkspace(new ProductSearchVM());
        }
    }
}