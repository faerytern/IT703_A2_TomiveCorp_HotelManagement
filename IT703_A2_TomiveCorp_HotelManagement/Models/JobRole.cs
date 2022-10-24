using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class JobRole
    {
        public int JobRoleId { get; set; }
        [StringLength(20)]
        public string RoleTitle { get; set; }
        public string RoleDescription { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
