using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using To_DoList_AspMVC.Data;
using To_DoList_AspMVC.Filters;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Controllers
{
    [SessionAuthorize]
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Client> clients = _context.Clients.Include(c => c.Nationality).ToList();
            return View(clients);
        }

        private void CreateTaskList()
        {
            var task = _context.TodoTasks.ToList();
            ViewBag.MyTasks = new SelectList(task, "Id", "Title");
        }


        private void CreateNationalityList()
        {
            var nati = _context.Nationalities.ToList();
            ViewBag.Nationalitys = new SelectList(nati, "Id", "Name_en");
        }


        public IActionResult TasksForClient(int id)
        {
            var client = _context.Clients
                .Include(c => c.MyTasks)
                .ThenInclude(t => t.Category) 
                .FirstOrDefault(c => c.Id == id);

            if (client == null)
                return NotFound();

            return View(client);
        }


        [HttpGet]
        public IActionResult Create()
        {
            CreateTaskList();
            CreateNationalityList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (!ModelState.IsValid)
            {
                CreateTaskList();
                CreateNationalityList();
                return View(client);
            }

            _context.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var clients = _context.Clients.Find(Id);
            CreateTaskList();
            CreateNationalityList();
            return View(clients);
        }

        [HttpPost]
        public IActionResult Edit(Client clients)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CreateNationalityList();
                    CreateTaskList();
                    return View(clients);

                }
                _context.Clients.Update(clients);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }







        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var clients = _context.Clients.Find(Id);
            CreateTaskList();
            CreateNationalityList();
            return View(clients);
        }

        [HttpPost]
        public IActionResult Delete(Client clients)
        {
            try
            {
                _context.Clients.Remove(clients);
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
