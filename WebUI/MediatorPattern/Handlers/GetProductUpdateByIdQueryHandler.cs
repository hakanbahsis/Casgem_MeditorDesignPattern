using MediatR;
using WebUI.DAL;
using WebUI.MediatorPattern.Queries;
using WebUI.MediatorPattern.Results;

namespace WebUI.MediatorPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, GetProductUpdateByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIdQueryResult
            {
                Id = values.Id,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                Brand = values.Brand
            };
        }
    }
}
