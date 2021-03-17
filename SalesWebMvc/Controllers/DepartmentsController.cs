using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department(1, "Eletronics"));
            list.Add(new Department(2, "Fashion"));
            list.Add(new Department(3, "Home"));

            return View(list);
        }
    }
}
