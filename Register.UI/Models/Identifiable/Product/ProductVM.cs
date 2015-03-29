using Interfaces.Identifiable;

namespace Register.UI.Models.Identifiable.Product
{
    public class ProductVM : BaseVM<IProduct>
    {
        protected ProductVM(IProduct product) : base(product)
        {
        }

        public long Id { get; set; }
        public string UPC { get; set; }
    }
}