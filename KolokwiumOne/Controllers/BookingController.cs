using KolokwiumOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumOne.Controllers;

[ApiController]
[Route("api/[controller]")] // -> adres api/warehouse
public class BookingController : ControllerBase
{
    private readonly IDbService _dbService;

    public BookingController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("manual")]
    public async Task<IEnumerable<IActionResult>> GetBookingAttractionRequestsAsync(int reservationId)
    {
    }
}