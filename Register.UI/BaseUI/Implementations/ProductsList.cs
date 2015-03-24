using System.Collections.Generic;
using System.Linq;
using Interfaces.VMBased;
using Interfaces.VMBased.Collections;
using Interfaces.VMBased.Identifiable.Selectable;

namespace Register.UI.BaseUI.Implementations
{
    public class ProductsList : BaseCollectionVM<IProduct>, IProductsList
    {
        public ProductsList(IProductsListOwner owner, IEnumerable<IProduct> products)
        {
            AddRange(products);
        }

        public IEnumerable<IProduct> SelectedProducts
        {
            get { return this.Where(p => p.Selected); }
        }
    }
}