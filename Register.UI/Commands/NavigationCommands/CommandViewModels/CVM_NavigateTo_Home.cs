using Register.UI.Home;
using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateToHomeCmd : HeaderLinkCommandVM
    {
        public NavigateToHomeCmd(IHeaderCommandContext headerCommandContext) : base(headerCommandContext)
        {
            DisplayName = "Home";
            DoExecute = o => HeaderCommandContext.AddWorkspace(new HomeVM());
        }
    }
}