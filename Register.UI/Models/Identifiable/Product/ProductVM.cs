using Interfaces.VMBased.Identifiable.Selectable;

namespace Register.UI.Models.Identifiable.Product
{
    public class ProductVM : BaseVM, ISelectableProduct
    {
        public long Id { get; set; }
        public bool IsSelected { get; set; }
    }
}