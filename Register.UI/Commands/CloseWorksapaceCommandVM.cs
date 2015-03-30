using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands
{
    public class CloseWorksapaceCommandVM : CloseCommandVM
    {
        public CloseWorksapaceCommandVM(IHeaderCommandContext headerCommandContext)
            : base(headerCommandContext.RemoveCurrentWorkspace)
        {
            DisplayName = "X";
            HeaderCommandContext = headerCommandContext;
            DoCanExecuteCheck = () => HeaderCommandContext.HasWorkspaces;
        }

        public IHeaderCommandContext HeaderCommandContext { get; set; }
        public string DisplayName { get; set; }
    }
}