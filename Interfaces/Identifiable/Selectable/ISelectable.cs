namespace Interfaces.Identifiable.Selectable
{
    public interface ISelectable : IIdentifiable
    {
        bool IsSelected { get; set; }
    }
}