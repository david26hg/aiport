using AirportV1.Dtos;
using AirportV1.Models;

namespace AirportV1.Mappers
{
    public static class FlightMapper
    {
        public static FlightDto ToFlightDto(this Flight flightModel)
        {
            return new FlightDto
            {
                FlightId = flightModel.FlightId,
                Origin = flightModel.Origin,
                DepartureDate = flightModel.DepartureDate,
                Destination = flightModel.Destination,
                ArrivalDate = flightModel.ArrivalDate
            };
        }

        public static Flight ToFlightFromCreateDto(this CreateFlightRequestDto flightDto)
        {
            return new Flight
            {
                FlightId = flightDto.FlightId,
                Origin = flightDto.Origin,
                Destination = flightDto.Destination,
                DepartureDate = flightDto.DepartureDate,                
                ArrivalDate = flightDto.ArrivalDate
            };
        }
    }
}
