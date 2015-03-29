using Interfaces.RequestFilters;

namespace Register.UI.Models
{
    public class ProductsFilter : IProductsFilter
    {
        public ProductsFilter()
        {
            Resource = "products";
        }

        public string ToUrl
        {
            get { return ""; }
        }

        protected string Resource { get; set; }
        public string FindBy { get; set; }
        public string FindByValue { get; set; }
    }
}