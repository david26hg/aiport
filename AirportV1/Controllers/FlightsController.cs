using AirportV1.Database;
using AirportV1.Models;
using Microsoft.AspNetCore.Mvc;
using AirportV1.Mappers;
using AirportV1.Dtos;

namespace AirportV1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly FlightDbContext _context;
          
        public FlightsController(FlightDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllFligth()
        {
            var flights = _context.Flight.ToList()
                .Select(s => s.ToFlightDto());

            if(flights == null)
            {
                return NotFound();
            }

            return Ok(flights);
        }

        [HttpPost]
        public IActionResult CreateFlight([FromBody] CreateFlightRequestDto flightDto)
        {
            var flightModel = flightDto.ToFlightFromCreateDto();
            _context.Flight.Add(flightModel);
            _context.SaveChanges();
            return Ok();

        }
    }
}
