namespace Interfaces.RequestFilters
{
    public interface IRequestFilter
    {
        string FindBy { get; set; }
        string FindByValue { get; set; }
    }
}