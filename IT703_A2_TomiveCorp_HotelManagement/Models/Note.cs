namespace IT703_A2_TomiveCorp_HotelManagement.Models
{

    public class Note
    {
        public int NoteId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string NoteName { get; set; }
        // Levels include normal for normal users, increased by staff for high profile customers etc
        public NoteType TypeOfNote { get; set; } = NoteType.Default;
        public NoteImportance Importance { get; set; } = NoteImportance.Normal;
        // Notes about a user can either be submitted by the user the notes are for, or by staff
        public string SubmittedBy { get; set; }

        public enum NoteType
        {
            Default,
            FoodAllergy,
            Likes,
            Dislikes,
            About,
        }
        public enum NoteImportance
        {
            Critical,
            Important,
            Normal
        }
    }
}