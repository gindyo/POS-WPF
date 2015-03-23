using System.Collections.Generic;
using System.Linq;
using Register.BaseUI;
using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;
using Register.Commands.NavigationCommands.ComandViewModels;
using Register.UserControls;

namespace Register.MainWindow
{
    public class MainWindowVM : BaseVM, IWorkspaceOwner
    {
        private IWorkspace _currentView;
        private IWorkspaces _workspaces;

        public MainWindowVM()
        {
            _workspaces = new Workspaces();
            NavigationLinks = new List<IUICommand>
            {
                new NavigateToSearchProductVM(this),
                new NavigateToSearchProductVM(this)
            };
            WorkspaceHeader = new WorkspaceHeaderVM(this);
        }

        public WorkspaceHeaderVM WorkspaceHeader { get; set; }

        public string Title
        {
            get { return (CurrentView == null ? "" : CurrentView.DisplayName); }
        }

        public List<IUICommand> NavigationLinks { get; set; }

        public IWorkspaces Workspaces
        {
            get
            {
                if (_workspaces == null)
                    _workspaces = new Workspaces();
                return _workspaces;
            }
        }

        public IWorkspace CurrentView
        {
            get { return _currentView; }
            set
            {
                if (value != null && !Workspaces.Contains(value))
                    Workspaces.Add(value);
                _currentView = value;
                OnPropertyChanged();
                WorkspaceHeader.Update();
            }
        }


        public void OnWorkspaceRequestClose()
        {
            Workspaces.Remove(CurrentView);
            CurrentView = Workspaces.FirstOrDefault();
        }
    }
}