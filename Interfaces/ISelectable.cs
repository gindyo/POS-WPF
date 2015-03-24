namespace Interfaces
{
    public interface IIdentifyable : IBaseVM
    {
        long Id { get; set; }
    }

    public interface ISelectable : IIdentifyable
    {
        bool IsSelected { get; set; }
    }

}