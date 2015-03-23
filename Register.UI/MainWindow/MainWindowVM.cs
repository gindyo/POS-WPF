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
            get { return (CurrentWorkspace == null ? "" : CurrentWorkspace.DisplayName); }
        }
        public List<IUICommand> NavigationLinks { get; set; }
        public IWorkspaces Workspaces
        {
            get { return _workspaces ?? (_workspaces = new Workspaces()); }
        }
        public IWorkspace CurrentWorkspace
        {
            get { return Workspaces.CurrentWorkspace; }
            set
            {
                if (value != null && !Workspaces.Contains(value))
                    Workspaces.AddWorkspace(value);
                OnPropertyChanged();
                WorkspaceHeader.Update();
            }
        }
        public bool HasWorkspaces()
        {
           return Workspaces.Any();
        }
        public void RemoveCurrentWorkspace()
        {
            Workspaces.RemoveCurrent();
        }
    }
}