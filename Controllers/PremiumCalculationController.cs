using Microsoft.AspNetCore.Mvc;

namespace InsuranceMVC.Controllers
{
    public class PremiumCalculationController : Controller
    {
        // GET: PremiumCalculationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PremiumCalculationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PremiumCalculationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PremiumCalculationController/Create
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

        // GET: PremiumCalculationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PremiumCalculationController/Edit/5
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

        // GET: PremiumCalculationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PremiumCalculationController/Delete/5
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
