using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String name { get; set; }
        public ICollection<Book_Category> book_Categories { get; set; }
        public Category()
        {
            book_Categories = new List<Book_Category>();
        }
    }
}
