using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class PretController : Controller
    {
        public IAbonne _ab;
       public  ILivre _liv;
       public  Ipret _pret;

        public PretController(IAbonne ab, ILivre liv, Ipret pret)
        {
            _ab = ab;
            _liv = liv;
            _pret = pret;
        }

        // GET: PretController
        public ActionResult Index(string? filter1, string? filter2)
        {
            if (!string.IsNullOrEmpty(filter1) || !string.IsNullOrEmpty(filter2))
                return View(_pret.GetAll().ToList()
                .Where(f => f.DateDebut.ToString().Equals( filter1) && f.DateFin.ToString().Equals(filter2)));
            return View(_pret.GetAll().ToList());
        }


        // GET: PretController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PretController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PretController/Create
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

        // GET: PretController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PretController/Edit/5
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

        // GET: PretController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PretController/Delete/5
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
