using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Demo.Sopra.MVC.Models;

namespace Demo.Sopra.MVC.Contr
{
    public class PedidosController : Controller
    {
        private ModelNorthwind _context;
        public IActionResult Index()
        {
            var pedidos = _context.Orders.Include(c => c.ShipViaNavigation);
            return View(pedidos);
        }

        public IActionResult Detalle(int id){
            var pedido = _context.Order_Details
            .Include(c => c.Product)
            .Where(c=> c.OrderID == id)
            .ToList();

            return PartialView("_PedidosDetalle",pedido);
        }
        public IActionResult Ficha(int id){
            var pedido = _context.Orders.Include(c => c.ShipViaNavigation)
            .Where(c=> c.OrderID == id)
            .First();

            return View(pedido);
        }
        public PedidosController(ModelNorthwind context){
            this._context = context;
        }
    }
}