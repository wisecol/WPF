using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    public class ProductsManagementMVVMViewModel : Notifier
    {
        #region 입력 출력 속성

        private string searchInput;
        private IEnumerable<Product> foundProducts;
        private Product selectedProduct;

        public string SearchInput
        {
            get { return searchInput; }
            set
            {
                searchInput = value;
                base.OnPropertyChanged("SearchInput");
                OnSearchInputChanged();
            }
        }

        public IEnumerable<Product> FoundProducts
        {
            get { return foundProducts; }
            set
            {
                foundProducts = value;
                base.OnPropertyChanged("FoundProducts");
            }
        }

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                base.OnPropertyChanged("SelectedProduct");
            }
        }

        #endregion

        ProductsFactory factory = new ProductsFactory();
        public ProductsManagementMVVMViewModel()
        {
            FoundProducts = Enumerable.Empty<Product>();
        }

        private void OnSearchInputChanged()
        {
            SelectedProduct = null;
            FoundProducts = factory.FindProducts(searchInput);
        }


    }
}
