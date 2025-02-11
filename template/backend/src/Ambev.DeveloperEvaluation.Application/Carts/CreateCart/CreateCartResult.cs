using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public List<BoughtProducts> Products { get; set; }
    }
}
