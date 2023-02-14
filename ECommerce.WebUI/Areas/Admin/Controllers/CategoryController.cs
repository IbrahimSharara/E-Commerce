using ECommerce.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        public ICategoryRepository Repo { get; }
        public CategoryController(ICategoryRepository repo)
        {
            Repo = repo;
        }


        public async Task< IActionResult> Index()
        {
            //List<Category> cat =await Repo.GetAll();
            //return View(cat);

            return View();
        }
    }
}
