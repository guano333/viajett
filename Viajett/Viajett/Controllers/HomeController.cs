using Business.Interfaces;
using System.Web.Mvc;
using System;
using Domain;

namespace Viajett.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ITaskService _taskService;

        public HomeController(IEmployeeService employeeService, ITaskService taskService)
        {
            _employeeService = employeeService;
            _taskService = taskService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogTime()
        {
            var temp = _taskService.GetAllTasksByTeam(new Team { TeamId = Guid.Parse("cfd33465-f0c4-4ad1-ae3c-1203db14f8af") });
            return PartialView(temp);
        }

        public ActionResult Teams()
        {
            var temp = _employeeService.GetActiveEmployeesByTeam(new Team { TeamId = Guid.Parse("cfd33465-f0c4-4ad1-ae3c-1203db14f8af") });
            return PartialView(temp);
        }

        public ActionResult Tasks()
        {
            var temp = _taskService.GetAllTasksByTeam(new Team { TeamId = Guid.Parse("cfd33465-f0c4-4ad1-ae3c-1203db14f8af") });
            return PartialView(temp);
        }

        public ActionResult Reports()
        {
            return PartialView();
        }
    }
}