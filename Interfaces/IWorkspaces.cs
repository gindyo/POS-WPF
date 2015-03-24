using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IWorkspaces : IList<IWorkspace>
    {
        IWorkspace CurrentWorkspace { get; set; }
        void AddWorkspace(IWorkspace value);
        void RemoveCurrent();
        IWorkspace Next();
        IWorkspace Previous();
        event Action OnCurrentItemChanged;
    }
}