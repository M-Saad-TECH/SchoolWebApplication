using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebApplication.Areas.Master.ViewModels
{
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
