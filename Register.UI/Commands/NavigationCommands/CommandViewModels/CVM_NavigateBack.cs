using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class NavigateBackCommandVM : HistoryCommandVM
    {
        public NavigateBackCommandVM(IHeaderCommandContext headerCommandContext) : base(headerCommandContext)
        {
        }

        protected override void NextWorkspace()
        {
            HeaderCommandContext.GoToPreviousWorkspace();
        }
    }
}