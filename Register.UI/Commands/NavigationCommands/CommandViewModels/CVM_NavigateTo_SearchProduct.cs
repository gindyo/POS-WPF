using Interfaces.VMBased;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToProductFinderCmd : OpenDialogCmd
    {
        private readonly IDialogVM _productFinder;

        public NavigateToProductFinderCmd(IDialogVM productFinder)
        {
            _productFinder = productFinder;
            DisplayName = "Product Search";
            DoCanExecuteCheck = () => true;
            DoExecute = o => Navigate();
        }

        private void Navigate()
        {
            OpenDialog(_productFinder);
        }
    }
}