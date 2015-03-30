using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces.Collections;
using Register.UI.Models;
using Services.Products;

namespace Register.UI.Commands
{
    public class FindProductsCommandVM : CommandVM
    {
        private readonly Action<IProductsList> _onProductsFound;

        public FindProductsCommandVM(Action<IProductsList> onProductsFound)
        {
            _onProductsFound = onProductsFound ?? delegate { };
            DoExecute = FindProducts;
            FindByOptions = new List<string> {Constants.FindByOptions.UPC};
            FindBy = FindByOptions.First();
        }

        public IEnumerable<string> FindByOptions { get; set; }
        public string FindBy { get; set; }
        public string FindByValue { get; set; }

        private void FindProducts(object value)
        {
            string findByValue = (value as string) ?? FindByValue;
            if (FindBy == null || findByValue == null)
                return;
            var filter = new ProductsFilter {FindBy = FindBy, FindByValue = findByValue};
            IProductsList products = new ProductsGetter().Get(filter);
            _onProductsFound(products);
        }
    }
}