using Interfaces.VMBased;

namespace Register.UI.MainWindow
{
    public partial class MainWindow : IDialogPresenter
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowModalDialog(IWorkspace ws)
        {
            var w = new DialogWindow(this, ws);
            w.ShowDialog();
        }

        public void ShowAsynchModalDialog(IWorkspace ws)
        {
            var w = new DialogWindow(this, ws);
            w.Show();
        }
    }

    public interface IDialogPresenter
    {
        void ShowModalDialog(IWorkspace ws);
        void ShowAsynchModalDialog(IWorkspace ws);
    }
}