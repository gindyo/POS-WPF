using System;
using Interfaces.Identifiable;
using Interfaces.VMBased;
using Register.UI.CollectionModels.ProductList;
using Register.UI.Models;
using Register.UI.ProductFinder;

namespace Register.UI.Home
{
    public class HomeVM : BaseVM<IBaseVM>, IWorkspace
    {
        private ProductsListVM<IProduct> _scannedProducts;

        public HomeVM()
        {
            DisplayName = "Welcome to POS";
            Action<SelectableProductListVM> onSubmit = products =>
                ScannedProducts = new ScannedProducts(products.SelectedProducts);
            ProductFinder = new ProductsFinderVM(onSubmit);
        }

        public ProductsListVM<IProduct> ScannedProducts
        {
            get { return _scannedProducts; }
            set
            {
                _scannedProducts = value;
                OnPropertyChanged();
            }
        }

        public ProductsFinderVM ProductFinder { get; private set; }
        public string DisplayName { get; set; }
    }
}