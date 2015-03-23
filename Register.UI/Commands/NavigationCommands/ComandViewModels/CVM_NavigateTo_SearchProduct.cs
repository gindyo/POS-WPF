using Register.BaseUI.Interfaces;
using Register.ProductSearch;

namespace Register.Commands.NavigationCommands.ComandViewModels
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
            var productSearchVM = new ProductSearchVM();
            WorkspaceOwner.CurrentWorkspace = productSearchVM;
        }
    }
}