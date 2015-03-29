using Interfaces.Collections;

namespace Register.UI.CollectionModels.ProductList
{
    public interface IProductsListOwner
    {
        IProductsList ProductsList { get; set; }
    }
}