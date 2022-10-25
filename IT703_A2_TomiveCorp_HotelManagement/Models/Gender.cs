using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public enum Gender
    {
        [Display(Name = "Unknown")]
        Unknown,
        [Display(Name = "Male")]
        Male,
        [Display(Name = "Female")]
        Female,
        [Display(Name = "Other / Choose not to disclose")]
        Other
    }
    
}
