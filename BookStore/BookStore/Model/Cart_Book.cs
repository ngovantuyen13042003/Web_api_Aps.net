using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    public class Cart_Book
    {
        public int cartId { get; set; }
        [ForeignKey("cartId")]
        public Cart cart { get; set; }
        public int bookId { get; set; }
        [ForeignKey("bookId")]
        public Book book { get; set; }
    }
}
