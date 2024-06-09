using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class ReservationInputType : InputObjectGraphType<Menu>
    {
        public ReservationInputType()
        {
            Field<IntGraphType>(name: "Id");
            Field<StringGraphType>(name: "CustomerName");
            Field<StringGraphType>(name: "Email");
            Field<StringGraphType>(name: "PhoneNumber");
            Field<DateGraphType>(name: "ReservationDate");
            Field<IntGraphType>(name: "PartySize");
            Field<StringGraphType>(name: "SpecialRequest");
        }
    }
}
