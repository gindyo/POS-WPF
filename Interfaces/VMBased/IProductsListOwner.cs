using Interfaces.VMBased.Collections;

namespace Interfaces.VMBased
{
    public interface IProductsListOwner : IBaseVM
    {
        IProductsList ProductsList { get; set; }
    }
}