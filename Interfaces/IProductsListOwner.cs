using System.ComponentModel;

namespace Interfaces
{
    public interface IProductsListOwner: INotifyPropertyChanged
    {
        IProductsList ProductsList { get; set; }
    }
}