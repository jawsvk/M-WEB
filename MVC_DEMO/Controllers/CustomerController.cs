using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DEMO.Controllers
{
    using Models;
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Count = new BusinessLogic().Count;
            return View();
        }
        public ActionResult Show(string id)
        {
            if (id == null)
            {
                ViewBag.CustList = new BusinessLogic().GetCustomers;
                return View();
            }
            else
            {
                Customer cust = new BusinessLogic().GetCustomer(id);
                if (cust == null)
                {
                    ViewBag.Id = id;
                    return View("NotFoundCustomer");
                }
                else
                {
                    ViewBag.Customer = cust;
                    return View("Details");
                }
            }
        }
    }
}