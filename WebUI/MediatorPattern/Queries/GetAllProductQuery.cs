using MediatR;
using WebUI.MediatorPattern.Results;

namespace WebUI.MediatorPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
