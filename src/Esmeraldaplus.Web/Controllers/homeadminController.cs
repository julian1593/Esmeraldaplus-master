using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esmeraldaplus.Web.Controllers
{
    public class homeadminController : Controller
    {
        // GET: homeadminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: homeadminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: homeadminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: homeadminController/Create
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

        // GET: homeadminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: homeadminController/Edit/5
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

        // GET: homeadminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: homeadminController/Delete/5
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
