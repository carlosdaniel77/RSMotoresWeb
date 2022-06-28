using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RsMotores.WEB.Models;
using RsMotores.WEB.Services;

namespace RsMotores.WEB.Controllers
{
    public class UsuarioController : Controller
    {
        
        // GET: Usuario/Show
        public ActionResult Show()
        {
            
            return View(UsuarioService.lUsers);
        }

        // GET: Usuario/Create
        public ActionResult Create(string msg)
        {
            //ViewBag.msg = msg;
            return View(msg);
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection objForm)
        {
            try
            {
                var usuario = new Usuario()
                {
                    cpf = objForm["cpf"].ToString(),
                    email = objForm["email"].ToString(),
                    Id = 1,
                    nome = objForm["nome"].ToString(),
                    password = objForm["senha"].ToString()
                };
                UsuarioService.lUsers.Add(usuario);
                return View("Create","Cadastrado com sucesso");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Usuario/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: Usuario/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here
        //
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Usuario/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}
        //
        //// POST: Usuario/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}