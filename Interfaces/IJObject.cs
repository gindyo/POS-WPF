namespace Interfaces
{
    public interface IJObject
    {
        T GetValue<T>(string property);
    }
}