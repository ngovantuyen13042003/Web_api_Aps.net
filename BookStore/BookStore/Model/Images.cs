using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model
{
    public class Images
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string NameImage { get; set; }
        public string TypeImage { get; set; }

        public byte[] DataImage { get; set; }

        public int BookId { get; set; } 
        public  ICollection<Book_Images> book_Images { get; set; }
        public Images()
        {
            book_Images = new List<Book_Images>();
        }
    }
}
