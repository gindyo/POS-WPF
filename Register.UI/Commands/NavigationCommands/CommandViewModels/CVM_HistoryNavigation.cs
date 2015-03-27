namespace Register.UI.Commands.NavigationCommands.CommandViewModels
{
    public class HistoryCommandVM : HeaderCommand
    {
        protected HistoryCommandVM(IWorkspaceOwner workspaceOwner) : base(workspaceOwner)
        {
            DoCanExecuteCheck = () => true;
            DoExecute = o => NextWorkspace();
        }


        protected virtual void NextWorkspace()
        {
        }
    }
}