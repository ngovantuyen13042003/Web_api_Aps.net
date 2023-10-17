using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    [Table("cart")]
    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCart { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public ICollection<Cart_Book> cart_Books{ get; set; }
        public Cart()
        {
            cart_Books = new List<Cart_Book>();
        }
    }
}
