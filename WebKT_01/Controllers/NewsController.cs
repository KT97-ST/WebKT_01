using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebKT_01.Controllers
{
    public class NewsController : Controller
    {
        /*
        // GET: NewsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */

        public IActionResult Index()
        {
            var article = new List<Aricle>
            {
                new Aricle { Id = 1,Title="Title 01", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 2,Title="Title 02", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 3,Title="Title 03", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 4,Title="Title 04", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 5,Title="Title 05", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 6,Title="Title 06", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 7,Title="Title 07", Content ="This is content", Author ="Kthanh"},
                new Aricle { Id = 8,Title="Title 08", Content ="This is content", Author ="Kthanh"}
            };


            // Option 1: Using ViewBag
            //ViewBag.Article = article;

            // Option 2: Using ViewData
            //ViewData["Articles"] = article;

            //Option 3: Use Model
            

            return View(article);
        }

        public string StringOut(int id, Employee employee)
        {
            return ($"Xin chao ban my number is {id} - my name is {employee.FistName} - {employee.LastName} ");
        }

        public IActionResult StringOut2(int id, Employee employee)
        {
            return Content($"Xin chao ban my number is {id} - my name is {employee.FistName} - {employee.LastName} ");
        }

        public IActionResult JsonOut(int id, Employee employee)
        {
            var obj = new {Id=id, Employee=employee}; 
            return Json(obj);
        }
    }

    public class Employee
    {
        public string FistName { get; set;}

        public string LastName { get; set;} 
    }

    public class Aricle
    {
        public int Id { get; set;}
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}
