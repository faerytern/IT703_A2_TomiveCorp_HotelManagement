using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female,
        [Display(Name = "Other / Choose not to disclose")]
        Other
    }
    
}
