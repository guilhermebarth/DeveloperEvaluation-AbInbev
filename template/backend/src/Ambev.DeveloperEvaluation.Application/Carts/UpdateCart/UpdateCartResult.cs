using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public List<BoughtProducts> Products { get; set; }
    }
}
