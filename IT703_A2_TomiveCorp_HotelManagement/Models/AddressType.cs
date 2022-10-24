using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    // https://support.nzpost.co.nz/s/article/What-is-the-correct-way-to-address-my-letters?language=en_US
    public enum AddressType
    {
        DomesticNZ,
        [Display(Name = "Po Box")]
        Po_Box,
        [Display(Name ="Private Bag")]
        Private_Bag,
        Rural,
        Parliament,
        OutsideNZ
        

    }
}