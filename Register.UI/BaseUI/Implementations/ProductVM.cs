using Interfaces.VMBased.Identifiable.Selectable;

namespace Register.UI.BaseUI.Implementations
{
    internal class ProductVM : BaseVM, IProduct
    {
        public bool Selected { get; set; }
    }
}