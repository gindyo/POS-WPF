using System.Collections.Generic;
using Register.BaseUI.Interfaces;

namespace Register.BaseUI.Implementations
{
    public class Workspaces : List<IWorkspace>, IWorkspaces
    {
        public  void AddWorkspace(IWorkspace item)
        {
            CurrentWorkspace = item;
            Add(CurrentWorkspace);
        }

        public void SetCurrentWorkspace(IWorkspace workspace)
        {
            CurrentWorkspace = workspace;
        }
        public IWorkspace CurrentWorkspace { get; set; }
        public void RemoveCurrent()
        {
            Remove(CurrentWorkspace);
        }
    }
}