using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI2.Model
{
    public class ApplicationDbContext : Controller
    {
        // GET: ApplicationDbContext
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicationDbContext/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationDbContext/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationDbContext/Create
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

        // GET: ApplicationDbContext/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationDbContext/Edit/5
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

        // GET: ApplicationDbContext/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationDbContext/Delete/5
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
