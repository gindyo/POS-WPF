using Register.UI.CollectionModels.ProductList;
using Register.UI.Commands;

namespace Register.UI.ProductFinder
{
    public class FindProductsCommand : UICommand
    {
        public FindProductsCommand(IFindProductCommandContext context) : base(context)
        {
            Context = context;
            DoExecute = FindProducts;
        }

        private void FindProducts(object parameter)
        {
            var upc = parameter as string;
        }
    }

    public interface IFindProductCommandContext : ICommandContext, IProductsListOwner
    {
    }
}