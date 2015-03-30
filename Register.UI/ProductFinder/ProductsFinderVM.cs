using System;
using System.Windows.Input;
using Interfaces.Collections;
using Interfaces.VMBased;
using Register.UI.CollectionModels.ProductList;
using Register.UI.Commands;
using Register.UI.Commands.NavigationCommands.CommandViewModels;
using Register.UI.Interfaces.Commands.CommandContexts;
using Register.UI.Models;

namespace Register.UI.ProductFinder
{
    public class ProductsFinderVM : BaseVM<IBaseVM>, IDialogVM, IFindProductsCommandContext
    {
        private ICommand _closeCmd;
        private SelectableProductListVM _foundProducts;


        public ProductsFinderVM(Action<SelectableProductListVM> onSubmit)
        {
            DisplayName = "Product Search";
            _onSubmit = onSubmit;
        }

        public FindProductsCommandVM FindProductsCommandVM
        {
            get { return new FindProductsCommandVM(OnProductsFound); }
        }

        private Action<IProductsList> OnProductsFound
        {
            get { return list => FoundProducts = new SelectableProductListVM(list); }
        }

        private Action<SelectableProductListVM> _onSubmit { get; set; }

        public string DisplayName { get; set; }

        public ICommand OpenCmd
        {
            get { return new NavigateToProductFinderCmd(this); }
        }

        public ICommand SubmitCmd
        {
            get { return new SubmitDialogCmd(this); }
        }

        public ICommand CloseCmd { get; set; }

        public void Submit()
        {
            _onSubmit(FoundProducts);
        }


        public SelectableProductListVM FoundProducts
        {
            get { return _foundProducts; }
            set
            {
                _foundProducts = value;
                OnPropertyChanged();
            }
        }
    }
}