﻿using AdotePetInnovation.Models;
using AdotePetInnovation.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdotePetInnovation.Controllers
{
    public class SigninController : Controller
    {
        private readonly ILogger<SigninController> _logger;

        private readonly IUserRepository _repo;
        public SigninController(IUserRepository repo
, ILogger<SigninController> logger            )
        {
            _repo = repo;
            _logger = logger;
        }
        // GET: Signup
        public ActionResult Login()
        {
            return View();
        }

        // POST: Signup/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(SigninViewModel signin)
        {
            var user = await _repo.GetByEmailAsync(signin.Email);
            if(user != null && user.Password == signin.Password){
                return RedirectToAction("Index",
                        "App");
            }
            ModelState.AddModelError("email","usuario/senha invalido");
            return View();
        }

        // POST: Signup/Delete/5
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