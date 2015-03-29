using Interfaces.VMBased;
using Register.UI.CollectionModels.ProductList;
using Register.UI.Commands;
using Register.UI.Interfaces.Commands.CommandContexts;
using Register.UI.Models;

namespace Register.UI.ProductFinder
{
    public class ProductsFinderVM : BaseVM<IBaseVM>, IWorkspace, IFindProductsCommandContext
    {
        private SelectableProductListVM _selectableProductsListVM;

        public ProductsFinderVM()
        {
            DisplayName = "Product Search";
        }

        public FindProductsCommandVM FindProductsCommandVM
        {
            get { return new FindProductsCommandVM(this); }
        }

        public SelectableProductListVM SelectableProductsListVM
        {
            get { return _selectableProductsListVM; }
            set
            {
                _selectableProductsListVM = value;
                OnPropertyChanged();
            }
        }

        public string DisplayName { get; set; }
    }
}