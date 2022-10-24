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
        /// <summary>
        /// To figure out whether a customer can add in a car park to their booking, get all the bookings between the date of their stay and compare the amount of car parks booked from that against the total
        /// </summary>
        public int NumberOfCarParks { get; set; }

        // Relationships
        public List<Employee> Employees { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
