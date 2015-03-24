using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Register.UI.BaseUI;
using Register.UI.BaseUI.Implementations;
using Register.UI.Commands.NavigationCommands.CommandViewModels;
using Register.UI.MainWindow.Header;
using Register.UI.UserControls;

namespace Register.UI.MainWindow
{
    public class MainWindowVM : BaseVM, IWorkspaceOwner
    {
        private readonly IWorkspaces _workspaces;

        public MainWindowVM()
        {
            _workspaces = new Workspaces();
            _workspaces.OnCurrentItemChanged += () => OnPropertyChanged("CurrentWorkspace");
            NavigationLinks = new List<IUICommand>
            {
                new NavigateToHomeCommandVM(this),
                new NavigateToSearchProductVM(this)
            };
            Header = new HeaderVM(this);
        }

        public HeaderVM Header { get; set; }

        public string Title
        {
            get { return (CurrentWorkspace == null ? "" : CurrentWorkspace.DisplayName); }
        }

        public List<IUICommand> NavigationLinks { get; set; }

        public IWorkspaces Workspaces
        {
            get { return _workspaces; }
        }

        public IWorkspace CurrentWorkspace
        {
            get { return Workspaces.CurrentWorkspace; }
        }

        public bool HasWorkspaces()
        {
            return Workspaces.Any();
        }

        public void RemoveCurrentWorkspace()
        {
            Workspaces.RemoveCurrent();
            OnPropertyChanged("CurrentWorkspace");
        }
    }
}