﻿using Microsoft.AspNetCore.Mvc;

namespace AdotePetInnovation.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Doar()
        {
            return View();
        }
        public IActionResult Conta()
        {
            return View();
        }
        public IActionResult Mensagens()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Publicar(IDictionary<string, object> model)
        {
            return new JsonResult(model.First());
        }
    }
}
