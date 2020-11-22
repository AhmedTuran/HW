using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    public class authorController : Controller
    {
        private readonly IBookRepository<author> authorRepository;

        public authorController(IBookRepository<author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        // GET: authorController
        public ActionResult Index()
        {
            var author = authorRepository.list();
            return View(author);
        }

        // GET: authorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: authorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: authorController/Create
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

        // GET: authorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: authorController/Edit/5
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

        // GET: authorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: authorController/Delete/5
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
    }
}
