using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class BoughtProducts : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
