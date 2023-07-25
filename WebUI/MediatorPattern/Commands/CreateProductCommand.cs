using MediatR;

namespace WebUI.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
