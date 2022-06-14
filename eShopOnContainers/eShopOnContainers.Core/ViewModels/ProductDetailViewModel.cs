using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.ViewModels
{
   public class ProductDetailViewModel:ViewModelBase
    {
        public ProductDetailViewModel()
        {
                
        }
        public override Task InitializeAsync(IDictionary<string, string> query)
        {
            return base.InitializeAsync(query);
        }

    }
}
