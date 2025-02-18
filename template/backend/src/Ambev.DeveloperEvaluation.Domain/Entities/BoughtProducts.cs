using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    [Table("BoughtProducts")]
    public class BoughtProducts : BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("productId")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("cartId")]
        public int CartId { get; set; }

    }
}
