using Register.UI.ProductFinder;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    internal class NavigateToProductFinderCmd : HeaderLinkCommand
    {
        public NavigateToProductFinderCmd(IWorkspaceOwner wsOwner) : base(wsOwner)
        {
            DisplayName = "Product Search";
            DoCanExecuteCheck = () => true;
            DoExecute = o => Navigate();
        }

        private void Navigate()
        {
            WorkspaceOwner.AddWorkspace(new ProductsFinderVM());
        }
    }
}