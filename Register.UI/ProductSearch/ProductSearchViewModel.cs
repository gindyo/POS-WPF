using System.Collections.Generic;
using Register.UI.BaseUI.Implementations;
using Register.UI.BaseUI.Interfaces;

namespace Register.UI.ProductSearch
{
    public class ProductSearchVM : IWorkspace
    {
        public ProductSearchVM()
        {
            DisplayName = "Product Search";
            Products = new ProductsList(new List<IProduct> {new Product()});
        }

        public ProductsList Products { get; set; }
        public string DisplayName { get; set; }
    }
}