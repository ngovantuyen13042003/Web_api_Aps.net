using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    [Table("book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String  name{ get; set; }
        public String  description { get; set; }
        public double  price { get; set; }
        public int amount { get; set; }
        public String author { get; set; }
        public int categoryId { get; set; }
        public Category category{ get; set; }
        public String  image { get; set; }

    }
}
