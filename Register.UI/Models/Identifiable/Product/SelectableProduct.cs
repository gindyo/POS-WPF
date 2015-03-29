using Interfaces.Identifiable;
using Interfaces.Identifiable.Selectable;

namespace Register.UI.Models.Identifiable.Product
{
    public class SelectableProduct : ProductVM, ISelectableProduct
    {
        public SelectableProduct(IProduct product) : base(product)
        {
        }

        public bool IsSelected { get; set; }
    }
}