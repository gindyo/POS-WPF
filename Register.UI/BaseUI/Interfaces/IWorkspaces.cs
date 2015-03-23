using System.Collections.Generic;

namespace Register.BaseUI.Interfaces
{
    public interface IWorkspaces : IList<IWorkspace>
    {
        void AddWorkspace(IWorkspace value);
        IWorkspace CurrentWorkspace { get; set; }
        void RemoveCurrent();
    }
}