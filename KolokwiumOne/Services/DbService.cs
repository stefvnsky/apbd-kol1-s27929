using System.ComponentModel;
using KolokwiumOne.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace KolokwiumOne.Services;

public class DbService : IDbService
{
    private readonly IConfiguration _configuration;
    public DbService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<BookingAttractionRequest>> GetBookingAttractionRequestsAsync(int reservationId)
    {
        await using var connection = new SqlConnection(_configuration.GetConnectionString("Default"));
        await connection.OpenAsync();
        
        await using var command = new SqlCommand();
        command.Connection = connection;
        
        var transaction = await connection.BeginTransactionAsync();
        command.Transaction = (SqlTransaction)transaction;
        
        try
        {
            //1. walidacja danych wejsciowych
            if (reservationId.Equals(0))
                throw new ArgumentException("Amount must be greater than zero");
            
            var result = new List<Atractions>();

            //2. Sprawdzanie czy rezerwacja o takim id istnieje
            command.CommandText = @"SELECT 1 FROM Booking WHERE BookingId = @booking_id";
            command.Parameters.AddWithValue("@booking_id", reservationId.BookingId);
            
            
            await transaction.CommitAsync(); 
        }
        catch (Exception)
        {
            await transaction.RollbackAsync(); 
            throw; 
        }	
    }

    public async Task AddReservationAsync(ReservationRequest reservation)
    {
        await using var connection = new SqlConnection(_configuration.GetConnectionString("Default"));
        await connection.OpenAsync();
        
        await using var command = new SqlCommand();
        command.Connection = connection;
        
        var transaction = await connection.BeginTransactionAsync();
        command.Transaction = (SqlTransaction)transaction;
        
        try
        {
            

            await transaction.CommitAsync(); 
        }
        catch (Exception)
        {
            await transaction.RollbackAsync(); 
            throw;
        }	
    }
}