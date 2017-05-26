using AW_Demo01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AW_Demo01.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.ProductName = "Visual studi c#";
            ViewBag.Credit = "5 creditos";
            ViewBag.Inicio = DateTime.Now;
            return View();
        }

        public ActionResult ListadoModel()
        {
            var pro = new Product();
            pro.ID = 100;
            pro.Name = "Pastel";
            pro.Price = 100;
            pro.Stock = 100;
            return View(pro);
        }
        public ActionResult ListadoModelo(string FilterByName)
        {

            FilterByName = string.IsNullOrWhiteSpace(FilterByName)?"":FilterByName;


             var Products = GetProduct();

            Products = (from p in Products
                        where p.Name.ToUpper().Contains(FilterByName.ToUpper())
                        select p).ToList();



            //ViewBag.Productos = Products;
            return View(Products);
        }


        public ActionResult Listado(string FilterByName)
        {

            FilterByName = string.IsNullOrWhiteSpace(FilterByName) ? "" : FilterByName;


            var Products = GetProduct();

            Products = (from p in Products
                        where p.Name.ToUpper().Contains(FilterByName.ToUpper())
                        select p).ToList();



            ViewBag.Productos = Products;
            return View();
        }

        private List<Product> GetProduct()
        {
            var result = new List<Product>();
            result.Add(new Product
            {
                ID = 1,
                Name = "Leche",
                Price = 247,
                Stock = 23 } );

            result.Add(new Product
            {
                ID = 2,
                Name = "Monitor",
                Price = 2454,
                Stock = 25
            });

            result.Add(new Product
            {
                ID = 3,
                Name = "Laptop",
                Price = 345,
                Stock = 45
            });


            result.Add(new Product
            {
                ID = 4,
                Name = "Mesas de Desktop",
                Price = 35,
                Stock = 145
            });

            return result;
        }
    }
}