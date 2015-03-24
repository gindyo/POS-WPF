using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Register.UI.BaseUI.Implementations
{
    public class BaseCollectionVM<T> : List<T>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}