using MediatR;
using WebUI.MediatorPattern.Results;

namespace WebUI.MediatorPattern.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
