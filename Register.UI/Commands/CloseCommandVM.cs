using System;
using System.ComponentModel;
using System.Linq;
using Register.BaseUI.Implementations;
using Register.BaseUI.Interfaces;

namespace Register.Commands
{
    public class CloseCommandVM : UICommand
    {
        public CloseCommandVM(IWorkspaceOwner workspaceOwner)
        {
            DisplayName = "X";
            WorkspaceOwner = workspaceOwner;
            DoExecute = () =>  WorkspaceOwner.RemoveCurrentWorkspace();
            DoCanExecuteCheck = () => WorkspaceOwner.HasWorkspaces();
        }

        public IWorkspaceOwner WorkspaceOwner { get; set; }
        public string DisplayName { get; set; }




    }
}