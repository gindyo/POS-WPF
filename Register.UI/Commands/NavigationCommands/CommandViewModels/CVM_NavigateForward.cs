using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateForwardCommandVM : HistoryCommandVM
    {
        public NavigateForwardCommandVM(IHeaderCommandContext headerCommandContext) : base(headerCommandContext)
        {
        }

        protected override void NextWorkspace()
        {
            HeaderCommandContext.GoToNextWorkspace();
        }
    }
}