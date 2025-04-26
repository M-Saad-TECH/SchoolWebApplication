using Microsoft.AspNetCore.Mvc;
using SchoolWebApplication.Areas.Master.IRepositories;
using SchoolWebApplication.Areas.Master.Repositories;

namespace SchoolWebApplication.Areas.Master.Controllers
{
    [Area("Master")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var data =await _departmentRepository.GetAllDep();
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }
    }
}
