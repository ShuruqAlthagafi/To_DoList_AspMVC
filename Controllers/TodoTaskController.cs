using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using To_DoList_AspMVC.Data;
using To_DoList_AspMVC.Filters;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Controllers
{
    [SessionAuthorize]
    public class TodoTaskController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TodoTaskController(ApplicationDbContext context)
        {
            _context = context;
        }

     


        [HttpGet]
        public IActionResult Index()
        {
            try
            {

                IEnumerable<MyTask> myTasks = 
                    _context.TodoTasks
                    .Include(c => c.Category)
                    .Include(c => c.Client)
                    .Include(c => c.Priority)
                    .ToList();
                return View(myTasks);



            }
            catch (Exception ex)
            {

                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }

        private void createList()
        {
            IEnumerable<Category> category = _context.Categories.ToList();
            SelectList selectListItems = new SelectList(category, "Id", "Name");
            ViewBag.Categories = selectListItems;

            IEnumerable<Client> clients = _context.Clients.ToList();
            SelectList selectListItems2 = new SelectList(clients, "Id", "Name");
            ViewBag.Clients = selectListItems2;

            var nati = _context.Priorities.ToList();
            ViewBag.Priorities = new SelectList(nati, "Id", "Name");
        }


        [HttpGet]
        public IActionResult Create()
        {
            createList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MyTask myTasks)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    createList();
                    return View(myTasks);

                }
                _context.TodoTasks.Add(myTasks);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }






        [HttpGet]
        public IActionResult Edit(string Uid)
        {
            var myTasks = _context.TodoTasks.FirstOrDefault(e=>e.Uid==Uid);
            createList();
            return View(myTasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MyTask myTasks, string Uid)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    createList();
                    return View(myTasks);

                }
                var Tas = _context.TodoTasks.FirstOrDefault(e => e.Uid == Uid);
                if (Tas != null)
                {
                    _context.TodoTasks.Update(Tas);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
               return View(myTasks);

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }







        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var myTasks = _context.TodoTasks.Find(Id);
            createList();
            return View(myTasks);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(MyTask myTasks)
        {
            try
            {
                _context.TodoTasks.Remove(myTasks);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }



    }
}
