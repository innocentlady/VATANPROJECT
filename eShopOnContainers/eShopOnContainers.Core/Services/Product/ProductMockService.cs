using eShopOnContainers.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.Products
{
    public class ProductMockService : IProductsService
    {
        private ObservableCollection<Product> MockProducts = new ObservableCollection<Product>
        {
                new Product()
                { Id = 1,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Product()
                { Id = 2,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/nano75pa1-2_small.jpg",
                    Name = string.Format("55NANO756PA"),
                    Cost = 11799,
                    Detail = "LG 55NANO756 55inc 139 CM NANOCELL 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",

                },
                new Product()
                { Id = 3,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4.799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Product()
                { Id = 4,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/philips/thumb/v2-88491_small.jpg",
                    Name = string.Format("GC5032/20"),
                    Cost = 1.599,
                    Detail = "PHILIPS GC5032/20 AZUR ELITE OPTİMAL TEMP TEKNOLOJİLİ BUHARLI ÜTÜ",

                },
                 new Product()
                 { Id = 5,
                     ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/arnica/thumb/130693-1_small.jpg",
                     Name = string.Format("IH32059 KÖPÜKLÜ EKO SİYAH"),
                     Cost = 1499,
                     Detail = "ARNICA KÖPÜKLÜ TÜRK KAHVE MAKİNESİ EKO SİYAH - IH32059",

                 },
                  new Product()
                  {   Id=6,
                      ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vivo/thumb/127471_small.jpg",
                      Name = string.Format("Y11s_SİYAH"),
                      Cost = 2799,
                      Detail = "Vivo Y11s 32 Gb Fantom Siyahı Akıllı Telefon",

                  } };
        public async Task<ObservableCollection<Product>> GetProductsAsync()
        {
            await Task.Delay(10);
            return MockProducts;

        }

        public async Task<Product> GetProductWithIDAsync(int ID)
        {
            await Task.Delay(10);
            return MockProducts.First(x => x.Id == ID);
        }
    }
}
