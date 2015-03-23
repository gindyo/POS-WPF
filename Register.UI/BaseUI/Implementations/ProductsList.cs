using System.Collections.Generic;
using System.Linq;
using Register.UI.BaseUI.Interfaces;

namespace Register.UI.BaseUI.Implementations
{
    public class ProductsList : List<IProduct>
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