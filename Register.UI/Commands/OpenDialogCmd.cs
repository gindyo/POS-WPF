using System.Windows;
using Interfaces.VMBased;
using Register.UI.MainWindow;

namespace Register.UI.Commands
{
    public class OpenDialogCmd : CommandVM
    {
        public void OpenDialog(IDialogVM ws)
        {
            var dialogPresenter = Application.Current.MainWindow as IDialogPresenter;
            if (dialogPresenter != null)
                dialogPresenter.ShowModalDialog(ws);
        }
    }
}