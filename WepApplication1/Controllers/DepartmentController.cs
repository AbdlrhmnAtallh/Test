using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentRepository idepartmentRepository;
        public DepartmentController(IDepartmentRepository _idepartmentRepository)
        {
            idepartmentRepository = _idepartmentRepository;
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Save (Department department)
        {
            idepartmentRepository.Add(department);
            return View("All",idepartmentRepository.All());
        }
        public IActionResult All()
        {
            return View(idepartmentRepository.All());
        }
    }
}
