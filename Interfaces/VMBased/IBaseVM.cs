using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Interfaces.VMBased
{
    public interface IBaseVM : INotifyPropertyChanged
    {
        void OnPropertyChanged([CallerMemberName] string propertyName = null);
    }

    public interface IDialogVM : IBaseVM, IWorkspace
    {
        ICommand OpenCmd { get; }
        ICommand SubmitCmd { get; }
        ICommand CloseCmd { get; set; }
        void Submit();
    }
}