namespace BookStore.Model
{
    public class Book_Images
    {
        public int bookId { get; set; }
        public Book book { get; set; }
        public int imageId { get; set; }
        public Images image { get; set; }
    }
}
