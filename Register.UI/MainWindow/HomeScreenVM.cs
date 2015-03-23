using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
