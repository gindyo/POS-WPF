using Register.UI.CollectionModels.ProductList;

namespace Register.UI.Interfaces.Commands.CommandContexts
{
    public interface IFindProductsCommandContext : ICommandContext
    {
        SelectableProductListVM SelectableProductsListVM { get; set; }
    }
}