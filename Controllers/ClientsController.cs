using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using To_DoList_AspMVC.Data;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Controllers
{
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


        private void CreateNationalityList()
        {
            var nati = _context.Nationalities.ToList();
            ViewBag.Nationalitys = new SelectList(nati, "Id", "Name_en");
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateNationalityList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (!ModelState.IsValid)
            {
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
