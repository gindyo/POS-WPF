using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Interfaces.Collections;
using Interfaces.Identifiable;
using Interfaces.RequestFilters;
using Interfaces.ServiceObjects;

namespace Services.Products
{
    public class ProductsGetter : IGetProducts
    {
        private readonly Backend _backend;

        public ProductsGetter()
        {
            _backend = new Backend();
        }

        public IProductsList Get(IRequestFilter productsFilter)
        {
            //var url = new BackendUrl(productsFilter);
            //IJObject products = _backend.Request(url.ToString());
            var product1 = new Product {UPC = "123"};
            var product2 = new Product {UPC = "321"};
            IEnumerable<Product> products =
                new List<Product> {product1, product2}.Where(
                    p => GetValue<string>(p, productsFilter.FindBy).Contains(productsFilter.FindByValue));
            return new ProductsList(products);
        }

        private T GetValue<T>(object product, string findBy)
        {
            Type type = product.GetType();
            PropertyInfo prop = type.GetProperty(findBy);
            return (T) prop.GetValue(product);
        }
    }

    public class Product : IProduct
    {
        public long Id { get; set; }
        public string UPC { get; set; }
    }
}