using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoleID { get; set; }
        public JobRole JobRole { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Gender Gender { get; set; } = Gender.Unknown;
        //Extend Identity to get phone number and email?
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
