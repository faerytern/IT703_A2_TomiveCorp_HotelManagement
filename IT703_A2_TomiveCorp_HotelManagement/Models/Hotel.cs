using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int NumberOfRooms { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        [Range(0,5)]
        [DisplayFormat(DataFormatString = "{0:#.#}")]
        public decimal StarRating { get; set; }
    }
}
