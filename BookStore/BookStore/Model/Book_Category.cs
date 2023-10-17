using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    [Table("book_category")]
    public class Book_Category
    {
        public int bookId { get; set; }
        public int categoryId { get; set; }
        public Book book{ get; set; }
        public Category category { get; set; }
    }
}
