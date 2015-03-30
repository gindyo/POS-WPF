using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands
{
    public class HeaderLinkCommandVM : CommandVM
    {
        protected readonly IHeaderCommandContext HeaderCommandContext;

        public HeaderLinkCommandVM(IHeaderCommandContext headerCommandContext)
        {
            HeaderCommandContext = headerCommandContext;
            DoCanExecuteCheck = () => true;
        }
    }
}