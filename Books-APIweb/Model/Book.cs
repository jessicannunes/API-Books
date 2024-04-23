using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books_APIweb.Model
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="int")]
        public int Isbn { get; set; }

        [Required]
        [StringLength(300)]
        public string? Title { get; set; }

        [Required]
        [StringLength (80)]
        public string? PublishingCompany{ get; set; }

        [Required]
        [Column(TypeName ="decimal(10,2)" ) ]
        public decimal? Price { get; set; }

    }
}
