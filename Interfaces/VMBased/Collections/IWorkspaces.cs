using System;
using System.Collections.Generic;

namespace Interfaces.VMBased.Collections
{
    public interface IWorkspaces : IList<IWorkspace>
    {
        IWorkspace CurrentWorkspace { get; set; }
        void AddWorkspace(IWorkspace value);
        void RemoveCurrent();
        IWorkspace Next();
        IWorkspace Previous();
        void GoToPrevious();
        void GoToNext();
        event Action OnCurrentItemChanged;
    }
}