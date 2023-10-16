namespace BookStore.Model
{
    public class Book_Images
    {
        public Guid bookId { get; set; }
        public Book book { get; set; }
        public Guid imageId { get; set; }
        public Images image { get; set; }
    }
}
