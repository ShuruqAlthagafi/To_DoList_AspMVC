﻿using Microsoft.AspNetCore.Mvc;
using To_DoList_AspMVC.Data;
using To_DoList_AspMVC.Models;

namespace To_DoList_AspMVC.Controllers
{
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

                IEnumerable<MyTask> myTasks = _context.TodoTasks.ToList();
                return View(myTasks);



            }
            catch (Exception ex)
            {

                return Content("حدث خطا  غير متوقع يرجي مراجهة الدعم الفني:0565455252545");
            }
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyTask myTasks)
        {
            try
            {
                if (!ModelState.IsValid)
                {

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
        public IActionResult Edit(int Id)
        {
            var myTasks = _context.TodoTasks.Find(Id);
            return View(myTasks);
        }

        [HttpPost]
        public IActionResult Edit(MyTask myTasks)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return View(myTasks);

                }
                _context.TodoTasks.Update(myTasks);
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
            var myTasks = _context.TodoTasks.Find(Id);
            return View(myTasks);
        }

        [HttpPost]
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
