namespace Interfaces.Identifiable
{
    public interface IProduct : IIdentifiable
    {
        string UPC { get; set; }
        string Description { get; set; }
        string QoH { get; set; }
    }
}