﻿
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Customer //: IdentityUser
    {
        // Identity basic extensions
        public int CustomerId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; } = Gender.Unknown;
        public byte[]? ProfilePhoto { get; set; }

        // Names
        [StringLength(10)]
        public Title Title { get; set; } = Title.None;

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        public string PreferredName { get; set; }

        
        // Defined requirements
        // Notes and preferences merged into one field
        public List<Note> Notes { get; set; }


        // Address stuff is a headache

        public AddressType AddressType { get; set; } = AddressType.DomesticNZ;

        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        public string? StreetNum { get; set; }
        public string? Suburb { get; set; }
        public string? City { get; set; }
        public int Postcode { get; set; } = 0;

    }
    
}
