using Microsoft.AspNetCore.Mvc;
using To_DoList_AspMVC.Data;
using To_DoList_AspMVC.Filters;
using To_DoList_AspMVC.Interfaces;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Controllers
{
    [SessionAuthorize]
    public class CategoriesController : Controller
    {
        // private readonly ApplicationDbContext _context;
        private readonly IRepository<Category> _repositoryCategory;
        public CategoriesController(IRepository<Category> repository)
        {
            _repositoryCategory = repository;
        }
        //public CategoriesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            //IEnumerable<Category> categories = _context.Categories.ToList();
            IEnumerable<Category> categories = _repositoryCategory.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            //_context.Categories.Add(category);
            //_context.SaveChanges();
            _repositoryCategory.Add(category);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Edit(string Uid)
        {
            //var category = _context.Categories.FirstOrDefault(e=>e.Uid == Uid);
            var category = _repositoryCategory.GetByUId(Uid);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category , string Uid)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return View(category);

                }
                //var cat = _context.Categories.FirstOrDefault(e => e.Uid == Uid);
                var cat = _repositoryCategory.GetByUId(Uid);
                if (cat != null)
                {
                    category.Name = cat.Name;
                    category.Description = cat.Description;
                    //_context.Categories.Update(cat);
                    //_context.SaveChanges();
                    _repositoryCategory.Update(category);
                    return RedirectToAction("Index");

                }
                return View(category);

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }







        [HttpGet]
        public IActionResult Delete(int Id)
        {
            //var category = _context.Categories.Find(Id);
            var category = _repositoryCategory.GetById(Id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {
            try
            {
                //_context.Categories.Remove(category);
                //_context.SaveChanges();
                _repositoryCategory.Delete(category.Id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }

    }
}