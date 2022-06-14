using eShopOnContainers.Core.Models.Products;
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
        public MainPageViewModel()
        {
            //servisleri burda tanımla.  

        }
        public override Task InitializeAsync(IDictionary<string, string> query)
        {    //servisten verileri çekme olayı
            return base.InitializeAsync(query);
        }
        private ObservableCollection<String> carouselitems = new ObservableCollection<String>()
              {
              "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/SE_cep_14-03--mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/11-2021/theone_banner_mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/samsung-s22-buyback-17-03-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/02-2022/HP_2_notebook_Mobil_Ilan_04.03.22.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/hp-ilan-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/intel-11700K-mob.jpg",
             };

        private List<Products> _items = new List<Products>(){
                new Products()
                {
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Products()
                {
                   ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/nano75pa1-2_small.jpg",
                    Name = string.Format("55NANO756PA"),
                    Cost = 11799,
                    Detail = "LG 55NANO756 55inc 139 CM NANOCELL 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",

                },
                new Products()
                {
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4.799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Products()
                {
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/philips/thumb/v2-88491_small.jpg",
                    Name = string.Format("GC5032/20"),
                    Cost = 1.599,
                    Detail = "PHILIPS GC5032/20 AZUR ELITE OPTİMAL TEMP TEKNOLOJİLİ BUHARLI ÜTÜ",

                },
                 new Products()
                {
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/arnica/thumb/130693-1_small.jpg",
                    Name = string.Format("IH32059 KÖPÜKLÜ EKO SİYAH"),
                    Cost = 1499,
                    Detail = "ARNICA KÖPÜKLÜ TÜRK KAHVE MAKİNESİ EKO SİYAH - IH32059",

                },
                  new Products()
                {
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vivo/thumb/127471_small.jpg",
                    Name = string.Format("Y11s_SİYAH"),
                    Cost = 2.799,
                    Detail = "Vivo Y11s 32 Gb Fantom Siyahı Akıllı Telefon",

                },
                   
        
               
            
        };
        public List<Products> Items
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

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    //Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }



        public ICommand NavigateSearch => new Command<string>(async (string query) =>
        {
        // await NavigationService.NavigateToAsync("Search");
        Console.WriteLine("Success");
        });

    }
}

