namespace BookStore.dto
{
    public class CartDTO
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int bookId { get; set; }
        public String customerId { get; set; }
        public Double totalPrice { get; set; }
        public int totalQuantity { get; set; }
    }
}
