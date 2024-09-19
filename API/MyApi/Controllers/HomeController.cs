using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using System.Linq;

namespace MyApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
           var products = _dbContext.Products.OrderBy(p => p.Id).ToList();

            return View(products);
        }
    }
}