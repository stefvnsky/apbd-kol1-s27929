namespace KolokwiumOne.Models;

public class BookingAttractionRequest
{
    public int BookingId { get; set; }
    
    public DateTime BookingDate { get; set; }
    public string GuestFirstName { get; set; }
    public string GuestLastName { get; set; }
    public DateTime GuestDateBirth { get; set; }
    
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public string EmployeeNumber { get; set; }

    public List<Atractions> Atractions { get; set; } = new();
}