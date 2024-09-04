namespace AirportV1.Models
{
    public class Flight 
    {
        //public Flight(int flightId, string origin, string destination, string departureDate, string arrivalDate)
        //{
        //    FlightId = flightId;
        //    Origin = origin;
        //    Destination = destination;
        //    DepartureDate = departureDate;
        //    ArrivalDate = arrivalDate;
        //}

        public int FlightId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
    }
}
