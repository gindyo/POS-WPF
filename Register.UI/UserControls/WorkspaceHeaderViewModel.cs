using System.Collections.Generic;
using System.Windows.Input;
using Interfaces;
using Register.UI.BaseUI;
using Register.UI.BaseUI.Implementations;
using Register.UI.Commands;
using Register.UI.Commands.NavigationCommands.CommandViewModels;

namespace Register.UI.UserControls
{
    public class WorkspaceHeaderVM : BaseVM
    {
        public WorkspaceHeaderVM(IWorkspaceOwner workspaceOwner)
        {
            WorkspaceOwner = workspaceOwner;
            NavigationLinks = workspaceOwner.NavigationLinks;
            NavigationLinks.ForEach(nl => SetCommand(nl as UICommand));
        }

        public List<IUICommand> NavigationLinks { get; set; }

        public IWorkspaceOwner WorkspaceOwner { get; set; }

        public ICommand NavigateBackCommand
        {
            get { return SetCommand(new NavigateBackCommandVM(WorkspaceOwner)); }
        }

        public ICommand NavigateForwardCommand
        {
            get { return SetCommand(new NavigateForwardCommandVM(WorkspaceOwner)); }
        }

        public ICommand CloseWorkspaceCommand
        {
            get { return SetCommand(new CloseCommandVM(WorkspaceOwner)); }
        }

        private ICommand SetCommand(UICommand command)
        {
            command.Executed += Update;
            return command;
        }

        public void Update()
        {
            OnPropertyChanged("CloseWorkspaceCommand");
            OnPropertyChanged("NavigateForwardCommand");
            OnPropertyChanged("NavigateBackCommand");
        }
    }
}