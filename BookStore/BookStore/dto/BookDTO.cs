using BookStore.Model;

namespace BookStore.dto
{
    public class BookDTO
    {
        public String name { get; set; }
        public String description { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public String author { get; set; }
        public int categoryId { get; set; }
        public String image { get; set; }
    }
}
