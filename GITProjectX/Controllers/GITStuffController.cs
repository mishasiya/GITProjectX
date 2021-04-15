using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GITProjectX.Controllers
{
    public class GITStuffController : Controller
    {
        // GET: GITStuffController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GITStuffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GITStuffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GITStuffController/Create
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

        // GET: GITStuffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GITStuffController/Edit/5
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

        // GET: GITStuffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GITStuffController/Delete/5
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
