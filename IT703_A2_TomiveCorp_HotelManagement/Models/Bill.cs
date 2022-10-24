using System.ComponentModel.DataAnnotations.Schema;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime TransactedOn { get; }
        /// <summary>
        /// Completely nullifies a transaction if set - does not appear/total amount is decreased on final bill.
        /// </summary>
        public DateTime? ChargedBackOn { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public TransactionPurpose Purpose { get; set; }
        public decimal Amount { get; set; }

    }
}
