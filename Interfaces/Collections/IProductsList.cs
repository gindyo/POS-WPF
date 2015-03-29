using System.Collections.Generic;
using Interfaces.Identifiable;

namespace Interfaces.Collections
{
    public interface IProductsList : IList<IProduct>
    {
    }

    public interface IProductsList<T> : IList<T>
    {
    }
}