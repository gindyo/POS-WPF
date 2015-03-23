using System.Collections.Generic;
using System.Linq;
using Register.BaseUI.Interfaces;

namespace Register.BaseUI.Implementations
{
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
}