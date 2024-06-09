using GraphQL.Types;

namespace GraphQLProject.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<CategoryMutation>("categoryMutation").Resolve(context => new { });
            Field<ReservationMutation>("reservationMutation").Resolve(context => new { });
            Field<MenuMutation>("menuMutation").Resolve(context => new { });
        }
    }
}
