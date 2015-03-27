using System.Collections.Generic;
using System.Windows.Input;
using Interfaces.Commands;
using Register.UI.Commands;
using Register.UI.Commands.NavigationCommands.CommandViewModels;
using Register.UI.Models;

namespace Register.UI.MainWindow.Header
{
    public class HeaderVM : BaseVM, ICommandContext
    {
        private readonly CloseCommandVM _closeWorkspaceCommand;
        private readonly NavigateBackCommandVM _navigateBackCommand;
        private readonly NavigateForwardCommandVM _navigateForwardCommand;

        public HeaderVM(IWorkspaceOwner workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            NavigationLinks = workspaceOwner.NavigationLinks;
        }


        public List<IUICommand> NavigationLinks { get; set; }
        public IWorkspaceOwner WorkspaceOwner { get; set; }

        public ICommand NavigateBackCommand
        {
            get { return new NavigateBackCommandVM(WorkspaceOwner); }
        }

        public ICommand NavigateForwardCommand
        {
            get { return new NavigateForwardCommandVM(WorkspaceOwner); }
        }

        public ICommand CloseWorkspaceCommand
        {
            get { return new CloseCommandVM(WorkspaceOwner); }
        }


        public List<string> PropertiesToUpdate
        {
            get { return new List<string> {"NavigateBackCommand", "NavigateForwardCommand"}; }
        }

        public void Update()
        {
            OnPropertyChanged("NavigateForwardCommand");
            OnPropertyChanged("CloseWorkspaceCommand");
            OnPropertyChanged("NavigateBackCommand");
        }
    }
}