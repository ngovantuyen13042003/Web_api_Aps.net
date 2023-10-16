using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    [Table("book_category")]
    public class Book_Category
    {
        public Guid bookId { get; set; }
        public Guid categoryId { get; set; }
        public Book book{ get; set; }
        public Category category { get; set; }
    }
}
