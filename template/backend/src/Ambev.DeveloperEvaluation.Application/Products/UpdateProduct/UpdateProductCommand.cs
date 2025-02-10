using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdateProductResponse>
    {
        public int Id { get; }
        public UpdateProductCommand(int id)
        {
            Id = id;
        }
    }
}
