using System.Linq;
using Interfaces;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
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
            NextWorkspace();
        }

        public virtual IWorkspace NextWorkspace()
        {
            return null;
        }
    }
}