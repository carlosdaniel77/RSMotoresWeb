using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RsMotores.WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost] //Data Anotation indicando que esse responde a requisição POST
        public IActionResult Index(string email, string password)
        {
            ErrorMessage erroDados;
            var userDados = new Usuario()
            {
                cpf = "1232312312",
                email = "admin@admin",
                nome = "Admin",
                password = "123456"
            };

            ViewBag.Title = "Mensagem de login";
            if (string.IsNullOrEmpty(email) && 
                string.IsNullOrEmpty(password) )
            {
                erroDados = new ErrorMessage(3);
                ViewBag.Msg = erroDados.msg;
                ViewBag.Icon = "error";
                ViewBag.Color = "#ff0000";
                return View("Error", erroDados);
            }
            else
            {
                if (email.Equals(userDados.email) && 
                    password.Equals(userDados.password))
                {
                    ViewBag.Msg = "Logado com sucesso";
                    ViewBag.Icon = "success";
                    ViewBag.Color = "Green";
                    return View(userDados);
                }
                else
                {
                    erroDados = new ErrorMessage(1);
                    ViewBag.Icon = "error";
                    ViewBag.Color = "Red";
                    ViewBag.Msg = erroDados.msg;
                    return View("Error",erroDados);
                }
                
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
