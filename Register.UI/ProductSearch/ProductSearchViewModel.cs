using Register.BaseUI.Interfaces;

namespace Register.ProductSearch
{
    public class ProductSearchVM : IWorkspace
    {
        public ProductSearchVM()
        {
            DisplayName = "Product Search";
        }

        public string DisplayName { get; set; }
    }
}