using BookStore.Data;
using BookStore.Model;
using System.Net;

namespace BookStore
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void SeedDataContext()
        {
            if (!dataContext.books.Any())
            {
                var bookCategories = new List<Book_Category>();
                {
                     new Book_Category()
                    {
                        book = new Book()
                        {
                            name = "Sách thánh",
                            description = "Sách thánh tăng sát thương phép",
                            price = 2000,
                            amount = 100,
                            language = "Việt Nam",
                            author = "Liên Quân Mobile",
                            publisher = "Garena",
                            book_Categories = new List<Book_Category>()
                            {
                                 new Book_Category{category = new Category() {name = "Sách phép"}}
                            },
                            book_Images = new List<Book_Images>()
                             {
                                 new Book_Images{image = new Images() {NameImage = "sachThanh", TypeImage = "jpg"}}
                             },
                            customer_Books = new List<Customer_Book>()
                             {
                                 new Customer_Book{ customer = new Customer(){  Address = "Quảng Trị", Gender="Nam", DateOfBirth = new DateTime(2003,04,13)} }
                             }
                        },
                        category = new Category()
                        {
                            name = "Sách phép"
                        }
                    };
                    dataContext.book_Categories.AddRange(bookCategories);
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
