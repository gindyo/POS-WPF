using System.Linq;
using Register.BaseUI.Interfaces;

namespace Register.Commands.NavigationCommands.ComandViewModels
{
    public class HistoryCommandVM : HeaderCommand
    {
        protected HistoryCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DoExecute = MoveNext;
            DoCanExecuteCheck = () => WorkspaceOwner.Workspaces.Any() && NextWorkspace() != null;
        }

        protected void MoveNext()
        {
            WorkspaceOwner.CurrentWorkspace = NextWorkspace();
        }

        public virtual IWorkspace NextWorkspace()
        {
            return null;
        }
    }
}