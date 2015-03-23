using Register.UI.BaseUI.Interfaces;

namespace Register.UI.MainWindow
{
    public class HomeScreenVM : IWorkspace
    {
        public HomeScreenVM()
        {
            DisplayName = "Welcome to POS";
        }

        public string DisplayName { get; set; }
    }
}