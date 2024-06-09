using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        [Obsolete]
        public ReservationMutation(IReservationRepo reservationRepo)
        {

            //write mutation to create reservation


            //write mutation to create category
            Field<CategoryType>("addreservation",
                              arguments: new QueryArguments(
                                                new QueryArgument<NonNullGraphType<ReservationInputType>> { Name = "reservation" }),
                                              resolve: context =>
                                              {
                                                  var reservation = context.GetArgument<Reservation>("reservation");
                                                  return reservationRepo.CreateReservation(reservation);
                                              });

        }
    }
}
