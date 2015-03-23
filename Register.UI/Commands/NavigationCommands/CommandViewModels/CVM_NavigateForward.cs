﻿using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateForwardCommandVM : HistoryCommandVM
    {
        public NavigateForwardCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
        }

        public override IWorkspace NextWorkspace()
        {
            int currentWorkspaceIndex = WorkspaceOwner.Workspaces.IndexOf(WorkspaceOwner.CurrentWorkspace);
            if (WorkspaceOwner.Workspaces.Count == currentWorkspaceIndex + 1)
                return null;
            return WorkspaceOwner.Workspaces[currentWorkspaceIndex + 1];
        }
    }
}