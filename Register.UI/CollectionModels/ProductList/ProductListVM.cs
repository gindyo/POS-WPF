using System.Collections.Generic;
using System.Linq;
using Interfaces.VMBased.Collections;
using Interfaces.VMBased.Identifiable.Selectable;
using Register.UI.Models.Identifiable.Product;

namespace Register.UI.CollectionModels.ProductList
{
    public class ProductListVM : BaseCollectionVM<ProductVM>, IProductsList
    {
        public ProductListVM(IProductsListOwner owner, IEnumerable<ProductVM> products)
        {
            AddRange(products);
        }

        public IEnumerable<ISelectableProduct> SelectedProducts
        {
            get { return this.Where(p => p.IsSelected); }
        }
    }
}