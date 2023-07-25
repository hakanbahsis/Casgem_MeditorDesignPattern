using MediatR;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.MediatorPattern.Queries;
using WebUI.MediatorPattern.Results;

namespace WebUI.MediatorPattern.Handlers
{
    public class ProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public ProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x=> new GetAllProductQueryResult
            {
                Brand=x.Brand,
                Category=x.Category,
                Id=x.Id,
                Name=x.Name,
                Price=x.Price,
                Stock=x.Stock
            }).AsNoTracking().ToListAsync();
        }
    }
}
