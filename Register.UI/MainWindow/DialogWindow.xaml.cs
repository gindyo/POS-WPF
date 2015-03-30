using System.Windows;
using Interfaces.VMBased;
using Register.UI.Commands;

namespace Register.UI.MainWindow
{
    public partial class DialogWindow
    {
        public DialogWindow(Window parent, IWorkspace ws)
        {
            Resources = parent.Resources;
            CloseCommand = new CloseCommandVM(Close);
            DataContext = this;
            InitializeComponent();
            Owner = parent;
            Width = 500;
            Height = 500;
            WindowStyle = WindowStyle.None;
            ShowInTaskbar = false;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            ResizeMode = ResizeMode.NoResize;
            ContentControl.Content = ws;
        }

        public CloseCommandVM CloseCommand { get; set; }
    }
}