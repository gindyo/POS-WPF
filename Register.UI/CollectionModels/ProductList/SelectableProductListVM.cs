using System.Collections.Generic;
using System.Linq;
using Interfaces.Identifiable;
using Register.UI.Models.Identifiable.Product;

namespace Register.UI.CollectionModels.ProductList
{
    public class SelectableProductListVM : ProductsListVM<SelectableProduct>
    {
        public SelectableProductListVM(IEnumerable<IProduct> products)
        {
            AddRange(products.Select(p => new SelectableProduct(p)));
        }

        public IList<IProduct> SelectedProducts
        {
            get { return this.Where(p => p.IsSelected).Select(p => p as IProduct).ToList(); }
        }
    }
}