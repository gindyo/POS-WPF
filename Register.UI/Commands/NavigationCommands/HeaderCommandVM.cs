using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderCommandVM : CommandVM
    {
        protected readonly IHeaderCommandContext HeaderCommandContext;

        public HeaderCommandVM(IHeaderCommandContext headerCommandContext)
        {
            HeaderCommandContext = headerCommandContext;
            DoCanExecuteCheck = () => HeaderCommandContext.HasWorkspaces;
        }
    }
}