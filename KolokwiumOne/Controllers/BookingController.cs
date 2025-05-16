using KolokwiumOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumOne.Controllers;

[ApiController]
[Route("api/[ontroller]")] // -> adres api/warehouse
public class BookingController : ControllerBase
{
    private readonly IDbService _dbService;
    
    public BookingController(IDbService dbService)
}