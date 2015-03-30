using Interfaces.VMBased;

namespace Register.UI.MainWindow
{
    public partial class MainWindow : IDialogPresenter
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowModalDialog(IDialogVM ws)
        {
            var w = new DialogWindow(this, ws);
            w.ShowDialog();
        }

        public void ShowAsynchModalDialog(IDialogVM ws)
        {
            var w = new DialogWindow(this, ws);
            w.Show();
        }
    }

    public interface IDialogPresenter
    {
        void ShowModalDialog(IDialogVM ws);
        void ShowAsynchModalDialog(IDialogVM ws);
    }
}