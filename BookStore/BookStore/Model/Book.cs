using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    [Table("book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public String  name{ get; set; }
        public String  description { get; set; }
        public double  price { get; set; }
        public int amount { get; set; }
        public String  language{ get; set; }
        public String author { get; set; }
        public String  publisher { get; set; }
        public ICollection<Book_Category> book_Categories{ get; set; }
        public ICollection<Book_Images> book_Images { get; set; }
        public ICollection<Customer_Book> customer_Books { get; set; }
        public ICollection<Cart_Book> cart_Books { get; set; }
        public Book()
        {
            book_Categories = new List<Book_Category>();
            book_Images = new List<Book_Images>();
            customer_Books = new List<Customer_Book>();
            cart_Books = new List<Cart_Book>();
        }


    }
}
