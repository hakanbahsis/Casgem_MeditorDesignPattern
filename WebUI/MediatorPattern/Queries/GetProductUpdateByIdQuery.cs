using MediatR;
using WebUI.MediatorPattern.Results;

namespace WebUI.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery:IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
