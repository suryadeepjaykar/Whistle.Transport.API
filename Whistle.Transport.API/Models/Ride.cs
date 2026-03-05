namespace Whistle.Transport.API.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public DateTime RideTime { get; set; }
    }
}
