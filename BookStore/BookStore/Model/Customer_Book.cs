using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    public class Customer_Book
    {
        public int bookId { get; set; }
        [ForeignKey("bookId")]
        public Book book { get; set; }
        public int customerId { get; set; }
        [ForeignKey("customerId")]
        public Customer customer { get; set; }
        public int quantity { get; set; }
        
        
    }
}
