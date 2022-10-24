
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Guest //: IdentityUser
    {
        // Identity basic extensions
        public int GuestId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; } = Gender.Unknown;
        public byte[]? ProfilePhoto { get; set; }

        // Names
        [StringLength(10)]
        public Title Title { get; set; } = Title.None;
        // Exchangeable for Identity's UserName attribute

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }
        
        public string PreferredName { get; set; }

        
        // Defined requirements
        // Notes and preferences merged into one field
        public List<Note> Notes { get; set; }

        public string AssociatedTravelAgent { get; set; }
        public string AssociatedCompany { get; set; }

        // Address stuff is a headache

        public AddressType AddressType { get; set; } = AddressType.DomesticNZ;

        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        public string? StreetNum { get; set; }
        public string? Suburb { get; set; }
        public string? City { get; set; }
        [DataType(DataType.PostalCode)]
        public string? Postcode { get; set; }

    }
    
}
