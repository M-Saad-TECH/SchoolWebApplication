using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SchoolAppEntities;
using SchoolWebApplication.Areas.Master.IRepositories;
using SchoolWebApplication.Areas.Master.ViewModels;

namespace SchoolWebApplication.Areas.Master.Repositories
{
    public class DepartmentRepository(UsmanAcademyContext context) : IDepartmentRepository
    {
        private readonly UsmanAcademyContext _context=context;
        public async Task<List<Department>> GetAllDep()
        {
            var dep =await _context.Departments.Where(x => x.IsDeleted == false && x.DepartmentId != 0).ToListAsync();
            return dep;
        }
    }
}
