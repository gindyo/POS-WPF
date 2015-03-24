using System.Linq;
using Interfaces;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class HistoryCommandVM : HeaderCommand
    {
        protected HistoryCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DoCanExecuteCheck = () => WorkspaceOwner.Workspaces.Any() && NextWorkspace() != null;
        }

        public virtual IWorkspace NextWorkspace()
        {
            return null;
        }
    }
}