using System.Windows;
using System.Windows.Controls;

namespace Register.UI.UserControls
{
    public class HorizontalItemsControl : ItemsControl
    {
        public HorizontalItemsControl()
        {
            var factory = new FrameworkElementFactory(typeof (StackPanel));
            factory.SetValue(StackPanel.OrientationProperty, Orientation.Horizontal);
            factory.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);
            var itemsPanelTemplate = new ItemsPanelTemplate(factory);
            ItemsPanel = itemsPanelTemplate;
        }
    }
}