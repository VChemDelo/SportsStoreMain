using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set;}
        public PagingInfo PagingInfo { get; set;}
    }
}
