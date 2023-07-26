using MediatR;
using WebUI.DAL;
using WebUI.MediatorPattern.Commands;

namespace WebUI.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.Id);
            values.Brand=request.Brand;
            values.Name=request.Name;
            values.Stock=request.Stock;
            values.Price=request.Price;
            values.Category=request.Category;
            await _context.SaveChangesAsync();
        }
    }
}
