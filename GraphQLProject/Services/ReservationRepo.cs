using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class ReservationRepo : IReservationRepo
    {
        private readonly ApplicationDbContext _context;
        public ReservationRepo(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
            return reservation;
        }

        public Task<List<Reservation>> GetReservations()
        {
            return Task.FromResult(_context.Reservations.ToList());
        }
    }
}
