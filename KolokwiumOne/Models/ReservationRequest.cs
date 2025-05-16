namespace KolokwiumOne.Models;

public class ReservationRequest
{
    public int BookingId { get; set; }
    public int GuestId { get; set; }
    public string EmployeeNumber { get; set; }
}