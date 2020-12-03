using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class CustomerController : Controller
    {
        public static List<CustomerModel> customer;

        public CustomerController()
        {
            customer = new List<CustomerModel>();
            customer.Add(new CustomerModel(0, "Margaret Windsor", 23));
            customer.Add(new CustomerModel(1, "Peter Penbridge", 4));
            customer.Add(new CustomerModel(2, "Charles Montgomery", 14));
            customer.Add(new CustomerModel(3, "Jessica Winstead", 23));
            customer.Add(new CustomerModel(4, "Trevor Baxter", 27));
            customer.Add(new CustomerModel(5, "Ronald Dolphe", 62));
        }
        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customer, customer[3]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customer, customer[Int32.Parse(CustomerNumber)]);
            return PartialView("_CustomerDetails", customer[Int32.Parse(CustomerNumber)]);
        }

        [HttpPost]
        public string GetMoreInfo(string CustomerNumber)
        {
            return "GetMoreInfo Success!";
        }

    }
}