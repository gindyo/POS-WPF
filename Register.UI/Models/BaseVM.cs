using System.ComponentModel;
using System.Runtime.CompilerServices;
using Interfaces.VMBased;

namespace Register.UI.Models
{
    public class BaseVM : IBaseVM
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}