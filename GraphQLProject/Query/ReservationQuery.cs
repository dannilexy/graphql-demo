using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepo reservationRepo)
        {
            Field<ListGraphType<ReservationType>>("reservations").ResolveAsync(async x =>
            {
                return await reservationRepo.GetReservations();
            });
        }
    }
}
