using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartCommand : IRequest<GetCartResult>
    {
        public int Id { get; }
        public GetCartCommand(int id)
        {
            this.Id = id;
        }
    }
}
