using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Administracion_Cliente_PEV.Models;
using PA.BusinessEntity.Base;
namespace Administracion_Cliente_PEV.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {


            return View(ModeloPerson.ListPerson());
        }

        public ActionResult UniquePerson(string BusinessEntityID)
        {
            if (BusinessEntityID==string.Empty )
            {
                return View(new Person());
            }

            else if (BusinessEntityID ==null)
            {
                return View(new Person());
            }
            else
            {
                return View(ModeloPerson.uniquePerson(BusinessEntityID));
            }


        }
    }
}