using MediatR;
using WebUI.DAL;
using WebUI.MediatorPattern.Commands;

namespace WebUI.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Brand = "Bilinmiyor",
                Price = 0,
                Category="Bilinmiyor"
            }) ;
            await _context.SaveChangesAsync();
        }
    }
}
