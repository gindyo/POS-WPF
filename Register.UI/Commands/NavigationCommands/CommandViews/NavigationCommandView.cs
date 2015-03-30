using System.Windows;
using System.Windows.Input;
using Register.UI.UserControls;

namespace Register.UI.Commands.NavigationCommands.CommandViews
{
    /// <summary>
    ///     Interaction logic for NavigationCommandView.xaml
    /// </summary>
    public class NavigationCommandView : CommandableUserControl
    {
        public NavigationCommandView()
        {
            MouseUp += NavigationCommandView_OnMouseUp;
        }

        private void NavigationCommandView_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var c = sender as FrameworkElement;
            var command = c.DataContext as ICommand;
            if (command != null)
                command.Execute(null);
        }
    }
}