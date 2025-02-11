using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public List<BoughtProducts> Products { get; set; }
    }
}
