using Register.BaseUI.Interfaces;

namespace Register.MainWindow
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