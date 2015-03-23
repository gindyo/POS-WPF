using System.Collections.Generic;
using System.Windows.Documents;
using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;

namespace Register.ProductSearch
{
    public class ProductSearchVM : IWorkspace
    {
        public ProductSearchVM()
        {
            DisplayName = "Product Search";
            Products = new ProductsList(new List<IProduct>{new Product()});
        }

        public ProductsList Products { get; set; }
        public string DisplayName { get; set; }
    }
}