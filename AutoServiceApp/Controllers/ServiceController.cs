using Microsoft.AspNetCore.Mvc;
using AutoServiceApp.Models;
using AutoServiceApp.Interfaces;

namespace AutoServiceApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRequestService _service;

        public ServiceController(IServiceRequestService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ServiceRequest request)
        {
            _service.Add(request);
            return RedirectToAction("Index");
        }
    }
}