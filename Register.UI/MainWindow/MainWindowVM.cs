using System.Collections.Generic;
using System.Linq;
using Interfaces.Commands;
using Interfaces.VMBased;
using Interfaces.VMBased.Collections;
using Register.UI.CollectionModels.WorkspaceList;
using Register.UI.Commands;
using Register.UI.Commands.NavigationCommands.CommandViewModels;
using Register.UI.Home;
using Register.UI.MainWindow.Header;
using Register.UI.Models;

namespace Register.UI.MainWindow
{
    public class MainWindowVM : BaseVM, IWorkspaceOwner
    {
        private readonly IWorkspaces _workspaces;
        private NavigateToHomeCmd _navigateHomeCmd;
        private NavigateToProductFinderCmd _navigateToProductFinderCmd;

        public MainWindowVM()
        {
            _workspaces = new WorkspaceList();
            _workspaces.OnCurrentItemChanged += () => OnPropertyChanged("CurrentWorkspace");
            _navigateHomeCmd = new NavigateToHomeCmd(this);
            _navigateToProductFinderCmd = new NavigateToProductFinderCmd(this);
            NavigationLinks = new List<IUICommand>
            {
                _navigateHomeCmd,
                _navigateToProductFinderCmd
            };
            Header = new HeaderVM(this);
        }

        public HeaderVM Header { get; set; }

        public string Title
        {
            get { return (CurrentWorkspace == null ? "" : CurrentWorkspace.DisplayName); }
        }

        public IWorkspaces Workspaces
        {
            get { return _workspaces; }
        }

        public List<IUICommand> NavigationLinks { get; set; }

        public IWorkspace CurrentWorkspace
        {
            get { return Workspaces.CurrentWorkspace; }
        }

        public bool HasWorkspaces
        {
            get { return !Workspaces.All(ws => ws is HomeVM); }
        }

        public void RemoveCurrentWorkspace()
        {
            Workspaces.RemoveCurrent();
            Header.Update();
        }

        public void GoToPreviousWorkspace()
        {
            Workspaces.GoToPrevious();
            Header.Update();
        }

        public void GoToNextWorkspace()
        {
            Workspaces.GoToNext();
            Header.Update();
        }

        public void AddWorkspace(IWorkspace ws)
        {
            Workspaces.AddWorkspace(ws);
            Header.Update();
        }
    }
}