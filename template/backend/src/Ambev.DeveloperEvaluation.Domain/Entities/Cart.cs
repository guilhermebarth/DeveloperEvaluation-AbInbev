using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    [Table("Cart")]
    public class Cart : BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("userId")]
        public int UserId { get; set; }

        [Column("date")]
        public string Date { get; set; }
        //public List<BoughtProducts> Products { get; set; }
    }
}
