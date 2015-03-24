namespace Interfaces.VMBased.Identifiable
{
    public interface IIdentifiable : IBaseVM
    {
        long Id { get; set; }
    }
}