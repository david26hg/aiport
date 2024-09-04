namespace AirportV1.Dtos
{
    public class CreateFlightRequestDto
    {
        public int FlightId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
    }
}
