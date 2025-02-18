using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("rating")]
        public int Rating { get; set; }

    }
}
