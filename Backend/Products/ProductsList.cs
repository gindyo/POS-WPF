using System.Collections.Generic;
using Interfaces.Collections;
using Interfaces.Identifiable;

namespace Services.Products
{
    public class ProductsList : List<IProduct>, IProductsList
    {
        public ProductsList(IEnumerable<IProduct> products)
        {
            AddRange(products);
        }
    }
}