using MediatR;

namespace WebUI.MediatorPattern.Handlers
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
