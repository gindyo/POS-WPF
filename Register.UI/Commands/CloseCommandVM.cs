using System;
using System.ComponentModel;
using System.Linq;
using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;

namespace Register.Commands
{
    public class CloseCommandVM : UICommand
    {
        public CloseCommandVM(IWorkspaceOwner workspaceOwner, string displayName = "X")
        {
            WorkspaceOwner = workspaceOwner;
        }

        public IWorkspaceOwner WorkspaceOwner { get; set; }
        public string DisplayName { get; set; }

        public bool CanExecute(object parameter)
        {
            return WorkspaceOwner.Workspaces.Any();
        }

        public void Execute(object parameter)
        {
            WorkspaceOwner.OnWorkspaceRequestClose();
            AfterExecute();
        }

        public event EventHandler CanExecuteChanged;
        public event Action Executed;

        public void AfterExecute()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}