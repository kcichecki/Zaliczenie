using BazaSprzetu.Logic;
using BazaSprzetu.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaSprzetu.Controllers
{
    public class SprzetController : Controller
    {
        SprzetManager sprzetManager = new SprzetManager();

        public IActionResult Index()
        {
            var sprzetList = sprzetManager.GetSprzets();
            return View(sprzetList);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SprzetModel sprzetModel)
        {
            sprzetManager.AddSprzet(sprzetModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = sprzetManager.GetSprzet(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            sprzetManager.RemoveSprzet(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = sprzetManager.GetSprzet(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(SprzetModel sprzet)
        {
            sprzetManager.UpdateSprzet(sprzet);
            return RedirectToAction("Index");
        }
    }
}
