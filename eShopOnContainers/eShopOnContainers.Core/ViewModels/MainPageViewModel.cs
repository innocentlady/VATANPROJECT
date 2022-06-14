using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.Products;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IProductsService _productsService;
        public MainPageViewModel()
        {
            _productsService = DependencyService.Get<IProductsService>();

        }
        public async override Task InitializeAsync(IDictionary<string, string> query)
        {    //servisten verileri çekme olayı
            Items = await _productsService.GetProductsAsync();
        }
        public ObservableCollection<string> Carouselitems
        {
            get => carouselitems;
            set
            {
                carouselitems = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> carouselitems = new ObservableCollection<string>()
            {
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/SE_cep_14-03--mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/11-2021/theone_banner_mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/samsung-s22-buyback-17-03-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/02-2022/HP_2_notebook_Mobil_Ilan_04.03.22.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/hp-ilan-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/intel-11700K-mob.jpg",
             };

      

        private ObservableCollection<Product> _items = new ObservableCollection<Product>();
        public ObservableCollection<Product> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }


        public ICommand ItemTappedCommand => new Command<Product>(async (item) =>
        {
            await NavigationService.NavigateToAsync("ProductDetail", new Dictionary<string, string> { { "ProductID", item.Id.ToString() } });

            //Console.WriteLine("Success");
        });

        public ICommand NavigateSearch => new Command<string>(async (string query) =>
        {
        // await NavigationService.NavigateToAsync("Search");
        Console.WriteLine("Success");
        });

    }
}

