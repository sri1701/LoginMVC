using LoginMVC.Models;
using LoginMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            //Checking the state of model passed as parameter.
            if (ModelState.IsValid)
            {
                //Service method to Login
                _service.Login(model);
                return RedirectToAction("GetUsers");
            }
            else
            {
                //If model state is not valid, the model with error message is returned to the View.
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var users = _service.GetUsers();
             return View("Details",users);
        }
    }
}
