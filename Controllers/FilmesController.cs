using MeuMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                //
            }
            return View(filme);
        }

        // GET: FilmeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Adicionar));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Adicionar));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FilmeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Adicionar));
            }
            catch
            {
                return View();
            }
        }
    }
}
