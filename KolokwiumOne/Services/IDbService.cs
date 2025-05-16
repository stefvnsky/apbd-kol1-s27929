using KolokwiumOne.Models;

namespace KolokwiumOne.Services;

public interface IDbService
{
    //1. GET api/bookings/{id}
    public Task<IEnumerable<BookingAttractionRequest>> GetBookingAttractionRequestsAsync(int reservationId);
    
    //2. POST api/bookings
    public Task AddReservationAsync(ReservationRequest reservation);
}