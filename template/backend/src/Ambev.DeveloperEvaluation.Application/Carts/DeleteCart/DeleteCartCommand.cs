using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.DeleteCart
{
    public class DeleteCartCommand : IRequest<DeleteCartResponse>
    {
        public int Id { get; }
        public DeleteCartCommand(int id)
        {
            Id = id;
        }
    }
}
