using Business.Interfaces;
using System.Web.Mvc;
using System;
using Domain;

namespace Viajett.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogTime()
        {
            return PartialView();
        }

        public ActionResult Teams()
        {
            //var temp = _employeeService.GetActiveEmployeesByTeam(new Team { TeamId = Guid.Parse("cfd33465-f0c4-4ad1-ae3c-1203db14f8af") });
            return PartialView();
        }

        public ActionResult Tasks()
        {
            return PartialView();
        }

        public ActionResult Reports()
        {
            return PartialView();
        }
    }
}