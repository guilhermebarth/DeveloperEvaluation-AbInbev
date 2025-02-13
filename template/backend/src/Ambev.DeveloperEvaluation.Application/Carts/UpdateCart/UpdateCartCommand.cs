using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartCommand : IRequest<UpdateCartResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public List<BoughtProducts> Products { get; set; }

        public UpdateCartCommand(int id, int userId, string date, List<BoughtProducts> products)
        {
            this.Id = id;
            this.UserId = userId;
            this.Date = date;
            this.Products = products;
        }
    }
}
