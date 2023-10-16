using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    public class Cart_Book
    {
        public Guid cartId { get; set; }
        [ForeignKey("cartId")]
        public Cart cart { get; set; }
        public Guid bookId { get; set; }
        [ForeignKey("bookId")]
        public Book book { get; set; }
    }
}
