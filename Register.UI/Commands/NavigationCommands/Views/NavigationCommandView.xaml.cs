using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Register.Commands.NavigationCommands.Views
{
    /// <summary>
    ///     Interaction logic for NavigationCommandView.xaml
    /// </summary>
    public partial class NavigationCommandView : CommandableUserControl
    {
        public NavigationCommandView()
        {
            InitializeComponent();
        }


        private void NavigationCommandView_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Command.Execute(null);
        }
    }

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