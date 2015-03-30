using Interfaces.VMBased;

namespace Register.UI.Commands
{
    public class SubmitDialogCmd : CommandVM
    {
        public SubmitDialogCmd(IDialogVM dialog)
        {
            DisplayName = "Submit";
            DoExecute += o =>
            {
                dialog.Submit();
                dialog.CloseCmd.Execute(null);
            };
        }
    }
}