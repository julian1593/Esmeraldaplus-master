using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esmeraldaplus.Web.Controllers
{
    public class InfoProductoController : Controller
    {
        // GET: InfoProductoController
        public ActionResult Producto1()
        {
            return View();
        }
        public IActionResult Producto2()
        {
            return View();
        }
        public IActionResult Producto3()
        {
            return View();
        }
        public IActionResult Producto4()
        {
            return View();
        }
        public IActionResult Producto5()
        {
            return View();
        }
        public IActionResult Producto6()
        {
            return View();
        }
        public IActionResult Producto7()
        {
            return View();
        }
        public IActionResult Producto8()
        {
            return View();
        }
        public IActionResult Producto9()
        {
            return View();
        }
        // GET: InfoProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InfoProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoProductoController/Create
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

        // GET: InfoProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InfoProductoController/Edit/5
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

        // GET: InfoProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InfoProductoController/Delete/5
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
