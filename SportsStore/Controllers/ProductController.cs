using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 2;
        public ProductController(IProductRepository repo) 
        {
            repository = repo;
        }
        public ViewResult List(string category, int productPage = 1) => View(new ProductsListViewModel {Products = repository.Products.Where(p => category == null || p.Category == category).OrderBy(p=>p.ProductID).Skip((productPage-1)*PageSize),PagingInfo = new PagingInfo { CorrentPage = productPage, ItemsPerPage = PageSize, TotalItems = repository.Products.Count() }, CurrentCategory = category });
    }
}
