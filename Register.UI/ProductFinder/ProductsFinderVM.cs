using System.Collections.Generic;
using Interfaces;
using Register.UI.BaseUI;
using Register.UI.BaseUI.Implementations;

namespace Register.UI.ProductFinder
{
    public class ProductsFinderVM : BaseVM,IWorkspace, IProductsListOwner
    {
        public ProductsFinderVM()
        {
            DisplayName = "ProductVM Search";
            ProductsList = new ProductsList(this,new List<IProduct> {new ProductVM()});
        }
        public string DisplayName { get; set; }
        public IProductsList ProductsList { get; set; }
    }
}