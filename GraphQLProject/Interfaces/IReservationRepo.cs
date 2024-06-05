using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IReservationRepo
    {
        Task<List<Reservation>> GetReservations();
        Task<Reservation> CreateReservation(Reservation reservation);
    }
}
