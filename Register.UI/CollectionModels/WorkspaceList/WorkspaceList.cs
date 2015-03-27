using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces.VMBased;
using Interfaces.VMBased.Collections;
using Register.UI.Home;

namespace Register.UI.CollectionModels.WorkspaceList
{
    public class WorkspaceList : BaseCollectionVM<IWorkspace>, IWorkspaces
    {
        private IWorkspace _currentWorkspace;

        public WorkspaceList()
        {
            AddWorkspace(new HomeVM());
        }

        void ICollection<IWorkspace>.Add(IWorkspace item)
        {
            AddWorkspace(item);
        }

        public void AddWorkspace(IWorkspace item)
        {
            IWorkspace existingWorkspace = this.FirstOrDefault(ws => ws.GetType() == item.GetType());
            if (existingWorkspace == null)
            {
                Add(item);
                CurrentWorkspace = item;
            }
            else
            {
                CurrentWorkspace = existingWorkspace;
            }
        }

        public IWorkspace CurrentWorkspace
        {
            get { return _currentWorkspace; }
            set
            {
                if (value == null) return;
                _currentWorkspace = value;
                if (OnCurrentItemChanged != null) OnCurrentItemChanged();
            }
        }

        public void RemoveCurrent()
        {
            IWorkspace previous = Previous();
            if (CurrentWorkspace is HomeVM)
                return;
            Remove(CurrentWorkspace);
            CurrentWorkspace = previous;
        }

        public IWorkspace Previous()
        {
            int currentWorkspaceIndex = IndexOf(CurrentWorkspace);
            if (currentWorkspaceIndex <= 0)
            {
                CurrentWorkspace = new HomeVM();
                return CurrentWorkspace;
            }
            return this[currentWorkspaceIndex - 1];
        }

        public void GoToPrevious()
        {
            CurrentWorkspace = Previous();
        }

        public void GoToNext()
        {
            CurrentWorkspace = Next();
        }

        public IWorkspace Next()
        {
            int currentWorkspaceIndex = IndexOf(CurrentWorkspace);
            if (Count == currentWorkspaceIndex + 1)
                return null;
            return this[currentWorkspaceIndex + 1];
        }

        public event Action OnCurrentItemChanged;

        private new void Add(IWorkspace item)
        {
            base.Add(item);
        }

        public void SetCurrentWorkspace(IWorkspace workspace)
        {
            CurrentWorkspace = workspace;
        }
    }
}