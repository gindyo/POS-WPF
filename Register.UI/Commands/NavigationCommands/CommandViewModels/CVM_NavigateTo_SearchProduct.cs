using Register.UI.Interfaces.Commands.CommandContexts;
using Register.UI.ProductFinder;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    internal class NavigateToProductFinderCmd : HeaderLinkCommandVM
    {
        public NavigateToProductFinderCmd(IHeaderCommandContext wsOwner) : base(wsOwner)
        {
            DisplayName = "Product Search";
            DoCanExecuteCheck = () => true;
            DoExecute = o => Navigate();
        }

        private void Navigate()
        {
            HeaderCommandContext.AddWorkspace(new ProductsFinderVM());
        }
    }
}