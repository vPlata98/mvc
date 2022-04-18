using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Sopra.MVC.Models;

namespace Demo.Sopra.MVC.Contr
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Titulo de la pagina";
            Alumno alum = new Alumno(){
                Nombre = "jose", Apellidos = "Juan", Edad = 23
            };
            ViewBag.Alumno = alum; 
            return View(alum);
        }
    }
}