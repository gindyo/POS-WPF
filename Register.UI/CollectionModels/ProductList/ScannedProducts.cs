using System.Collections.Generic;
using Interfaces.Identifiable;

namespace Register.UI.CollectionModels.ProductList
{
    public class ScannedProducts : ProductsListVM<IProduct>
    {
        public ScannedProducts(IEnumerable<IProduct> products)
        {
            if (products != null)
                AddRange(products);
        }
    }
}