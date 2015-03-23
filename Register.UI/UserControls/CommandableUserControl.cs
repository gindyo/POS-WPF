using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Register.UI.UserControls
{
    public class CommandableUserControl : UserControl
    {
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof (ICommand), typeof (CommandableUserControl), new PropertyMetadata(default(ICommand)));

        public ICommand Command
        {
            get { return (ICommand) GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
    }
}