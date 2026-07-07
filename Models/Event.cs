namespace CampusBuzzAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string TicketPrice { get; set; } = string.Empty;
    }
}
