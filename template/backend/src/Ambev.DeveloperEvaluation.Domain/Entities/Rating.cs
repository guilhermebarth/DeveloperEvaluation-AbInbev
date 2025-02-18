using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    [Table("Rating")]
    public class Rating : BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("rate")]
        public decimal Rate { get; set; }

        [Column("count")]
        public int Count { get; set; }
    }
}