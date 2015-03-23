using System.Collections.Generic;
using System.Linq;
using Register.BaseUI.Interfaces;

namespace Register.ProductSearch
{
    public class ProductSearchVM : IWorkspace
    {
        public ProductSearchVM()
        {
            DisplayName = "Product Search";
        }

        public ProductsList Products;
        public string DisplayName { get; set; }
    }

    public class ProductsList: List<IProduct>
    {
        public ProductsList(IEnumerable<IProduct> products) 
        {
            AddRange(products);      
        }

        public IEnumerable<IProduct> SelectedProducts 
        {
            get { return this.Where(p => p.Selected); }
        }
    }

    public interface IProduct
    {
        bool Selected { get; set; }
    }
}