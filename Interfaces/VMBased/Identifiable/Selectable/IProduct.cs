namespace Interfaces.VMBased.Identifiable.Selectable
{
    public interface IProduct : IBaseVM
    {
        bool Selected { get; set; }
    }
}