using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Register.UI.MainWindow;

namespace Register.UI.BaseUI.Implementations
{
    public class Workspaces : List<IWorkspace>, IWorkspaces
    {
        private IWorkspace _currentWorkspace;

        public Workspaces()
        {
            AddWorkspace(new HomeScreenVM());
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
                _currentWorkspace = value;
                if (OnCurrentItemChanged != null) OnCurrentItemChanged();
            }
        }

        public void RemoveCurrent()
        {
            IWorkspace previous = Previous();
            if (CurrentWorkspace is HomeScreenVM)
                return;
            Remove(CurrentWorkspace);
            CurrentWorkspace = previous;
        }

        public IWorkspace Previous()
        {
            int currentWorkspaceIndex = IndexOf(CurrentWorkspace);
            if (currentWorkspaceIndex <= 0)
            {
                CurrentWorkspace = new HomeScreenVM();
                return CurrentWorkspace;
            }
            return this[currentWorkspaceIndex - 1];
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