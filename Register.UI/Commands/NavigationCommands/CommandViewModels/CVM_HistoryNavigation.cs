using Register.UI.Interfaces.Commands.CommandContexts;

namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class HistoryCommandVM : HeaderCommandVM
    {
        protected HistoryCommandVM(IHeaderCommandContext headerCommandContext) : base(headerCommandContext)
        {
            DoCanExecuteCheck = () => true;
            DoExecute = o => NextWorkspace();
        }


        protected virtual void NextWorkspace()
        {
        }
    }
}