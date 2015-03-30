using System;

namespace Register.UI.Commands
{
    public class CloseCommandVM : CommandVM
    {
        public CloseCommandVM(Action close)
        {
            DoExecute = o =>
                close();
        }

        protected CloseCommandVM()
        {
        }
    }

    public class CloseDialogCmd : CloseCommandVM
    {
    }

    public class CloseWorkspaceCmd : CloseCommandVM
    {
    }
}