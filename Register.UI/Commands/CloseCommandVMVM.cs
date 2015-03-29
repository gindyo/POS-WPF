using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands
{
    public class CloseCommandVMVM : CommandVM
    {
        public CloseCommandVMVM(IHeaderCommandContext headerCommandContext)
        {
            DisplayName = "X";
            HeaderCommandContext = headerCommandContext;
            DoExecute = o => HeaderCommandContext.RemoveCurrentWorkspace();
            DoCanExecuteCheck = () => HeaderCommandContext.HasWorkspaces;
        }

        public IHeaderCommandContext HeaderCommandContext { get; set; }
        public string DisplayName { get; set; }
    }
}