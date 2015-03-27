using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Interfaces.VMBased
{
    public interface IBaseVM : INotifyPropertyChanged
    {
        void OnPropertyChanged([CallerMemberName] string propertyName = null);
    }
}