//using ECommerce.DAL.Models;
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

        #region Show All Categories
        public async Task<IActionResult> Index()
        {
            var cat = await Repo.GetAll();
            return View(cat);
        }
        #endregion

        #region Add New Category
        public IActionResult Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryVM modle)
        {
            if (!ModelState.IsValid)
                ViewBag.result = "Error";
            Category newCat = new Category
            {
                Name = modle.Name,
                Description = modle.Description
            };
            int result = await Repo.Add(newCat);
            if (result > 0)
                ViewBag.result = "inserted successfully";
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete Category
        public async Task<IActionResult> Delete(int id)
        {
            var c = await Repo.GetById(id);
            Repo.Delete(c);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details of Category
        public async Task<IActionResult> Details(int id)
        {
            var c = await Repo.GetById(id);
            CategoryVM details = new CategoryVM
            {
                Name = c.Name,
                Description = c.Description,
            };
            return PartialView("_Details", details);
        }
        #endregion

        #region Update Category
        public async Task<IActionResult> Update(int id)
        {
            Category cat =await Repo.GetById(id);
            CategoryVM cVM = new CategoryVM
            {
                Name = cat.Name,
                Description = cat.Description,
            };
            return View( "_Update",cVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id , CategoryVM vm)
        {
            Category c = new Category
            {
                Name = vm.Name,
                ID = vm.ID,
                Description = vm.Description
            };
            int result =  Repo.UpdateCategory(id, c);
            if(result >0)
            {
                ViewBag.result = "Error";
            }else
                ViewBag.result = "Error";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
