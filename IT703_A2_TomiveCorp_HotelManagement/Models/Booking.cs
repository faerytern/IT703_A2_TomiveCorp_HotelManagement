using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        //Properties
        public string MethodOfBooking { get; set; } //On ERD as booking type, in sample sql code provided this was meant to convey how customer booked
        public DateTime CreatedOn { get; } = DateTime.Now;
        /// <summary>
        /// Used by Customer/Guest when making a booking to say the day they will arrive on
        /// </summary>
        [DataType(DataType.Date)]
        public DateOnly ArrivalDate { get; set; }
        
        /// <summary>
        /// Optional for user to provide the time they will come in on as Poni requested
        /// </summary>
        [DataType(DataType.Time)]
        public TimeOnly? ArrivalTime { get; set; }
        /// <summary>
        /// Used by Customer/Guest when making a booking to represent their last day
        /// </summary>
        [DataType(DataType.Date)]
        public DateOnly DepartureDate { get; set; }

        /// <summary>
        /// Optional for user to provide the time they will leave as Poni requested
        /// </summary>
        [DataType(DataType.Time)]
        public TimeOnly? DepartureTime { get; set; }

        /// <summary>
        /// Used by employees to check a guest in. 
        /// Use to see if a customer has checked in early - see ERD with EarlyArrive field in Booking Table
        /// Customer shouldnt be able to make bills while they arent checked in.
        /// </summary>
        public DateTime? Checked_In { get; set; }
        /// <summary>
        /// Used by employees to check a guest out
        /// Use to see if a customer has checked out late - see ERD with LateCheckOut field in Booking Table
        /// </summary>
        public DateTime? Checked_Out { get; set; }
        [Range(1,10)]
        public int NumberOfAdults { get; set; } = 1;
        [Range(0, 10)]
        public int NumberOfChildren { get; set; }

        [DataType(DataType.MultilineText)]
        public string SpecialRequest { get; set; }
        public bool CarPark { get; set; }
        public DateTime? DepositRecievedOn { get; set; }
        public string DepositMethod { get; set; } = string.Empty;
        public DateTime? PaymentRecievedOn { get; set; }
        public PaymentType PaymentMethod { get; set; }
        /// <summary>
        /// To see if confirmed, check whether it is null
        /// </summary>
        public DateTime? ConfirmedOn { get; set; }




        //Relationships


        // Dont need since hotel is findable through room?
        //public int HotelId { get; set; }
        //public Hotel Hotel { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int CustomerId { get; set; }
        public Guest Customer { get; set; }
    }
}