using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion_Cliente_PEV.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ViewBag.ID = 1;
            ViewBag.Nombre = "Zarmir";
            ViewBag.ApellidoPaterno = "Pillihuaman";
            ViewBag.ApellidoMaterno = "Hurtao";
            ViewBag.Estado = true;
            return View();
        }
    }
}