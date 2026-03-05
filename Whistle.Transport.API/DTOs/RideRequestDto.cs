namespace Whistle.Transport.API.DTOs
{
    public class RideRequestDto
    {
        public int EmployeeId { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
    }
}
