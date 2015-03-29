using System.Collections.Generic;
using System.Linq;
using Interfaces.Collections;
using Register.UI.CollectionModels.ProductList;
using Register.UI.Interfaces.Commands.CommandContexts;
using Register.UI.Models;
using Services.Products;

namespace Register.UI.Commands
{
    public class FindProductsCommandVM : CommandVM
    {
        private readonly IFindProductsCommandContext _context;

        public FindProductsCommandVM(IFindProductsCommandContext context)
        {
            _context = context;
            DoExecute = FindProducts;
            FindByOptions = new List<string> {"UPC"};
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
            _context.SelectableProductsListVM = new SelectableProductListVM(products);
        }
    }
}