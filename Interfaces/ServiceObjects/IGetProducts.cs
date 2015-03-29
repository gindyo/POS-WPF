using Interfaces.Collections;
using Interfaces.RequestFilters;

namespace Interfaces.ServiceObjects
{
    public interface IGetProducts
    {
        IProductsList Get(IRequestFilter productsFilter);
    }
}