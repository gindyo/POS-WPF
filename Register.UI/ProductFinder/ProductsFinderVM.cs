using System.Collections.Generic;
using Interfaces.VMBased;
using Register.UI.CollectionModels.ProductList;
using Register.UI.Models;
using Register.UI.Models.Identifiable.Product;

namespace Register.UI.ProductFinder
{
    public class ProductsFinderVM : BaseVM, IWorkspace, IFindProductCommandContext
    {
        private FindProductsCommand _findProductCommand;

        public ProductsFinderVM()
        {
            DisplayName = "ProductVM Search";
            ProductList = new ProductListVM(this, new List<ProductVM> {new ProductVM {Id = 1}});
        }

        public FindProductsCommand FindProductsCommand
        {
            get
            {
                if (_findProductCommand != null)
                    return _findProductCommand;
                var command = new FindProductsCommand(this);
                return command;
            }
        }

        public ProductListVM ProductList { get; set; }
        public string DisplayName { get; set; }
    }
}