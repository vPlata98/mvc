using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Demo.Sopra.MVC.Models;

namespace Demo.Sopra.MVC.Contr
{
    public class ClientesController : Controller
    {
        private readonly ModelNorthwind _context;
        
        public ClientesController(ModelNorthwind context){
            this._context = context;
        }
        public IActionResult Index()
        {
            var clientes  = _context.Customers.ToList();
            
            return View(clientes);
        }

        public IActionResult Ficha(string id){
            var cliente = _context.Customers.Where(c => c.CustomerID == id);
            ViewBag.pedidos = _context.Orders
            .Include(c => c.ShipViaNavigation)
            .Where(c => c.CustomerID == id).ToList();
            return View(cliente.First());
        }
    }
}