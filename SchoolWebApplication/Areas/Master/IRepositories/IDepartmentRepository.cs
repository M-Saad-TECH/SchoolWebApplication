using SchoolAppEntities;
using SchoolWebApplication.Areas.Master.ViewModels;

namespace SchoolWebApplication.Areas.Master.IRepositories
{
    public interface IDepartmentRepository
    {
       Task<List<Department>> GetAllDep();
    }
}
