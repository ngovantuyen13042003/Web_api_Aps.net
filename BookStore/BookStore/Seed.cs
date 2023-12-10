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
                var books = new List<Book>();
                {
                     new Book()
                    {
                        name = "Sách thánh",
                        description = "Sách thánh tăng sát thương phép",
                        price = 2000,
                        amount = 100,
                        author = "Liên Quân Mobile",
                        category = new Category()
                        {
                            name = "Sách phép"
                        }
                    };
                    dataContext.books.AddRange(books);
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
