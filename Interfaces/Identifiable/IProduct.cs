namespace Interfaces.Identifiable
{
    public interface IProduct : IIdentifiable
    {
        string UPC { get; set; }
    }
}