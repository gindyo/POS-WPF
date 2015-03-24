using Register.Base.AbstractViewModels;
using Register.Base.Interfaces;

namespace Register.ProductSearch
{
    public class NavigateProductSearchCommand : WorkspaceNavigationCommandVM
    {
        protected NavigateProductSearchCommand(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            var productSearchVM = new ProductSearchVM();
            workspaceOwner.Workspaces.Add(productSearchVM);
            workspaceOwner.CurrentView = productSearchVM;
        }
    }
}