using BookStore.Data;
using BookStore.dto;
using BookStore.Model;

namespace BookStore.repository.repositoryImpl
{
    public class BookRepositoryImpl : BookRepository
    {

        private readonly DataContext context;
        private readonly CategoryRepository categoryRepository;

        public BookRepositoryImpl(DataContext _context)
        {
            this.context = _context;
        }

        public Book add(BookDTO book)
        {
            Book b = new Book();
            b.author = book.author;
            b.description = book.description;
            b.name = book.name;
            b.price = book.price;
            b.amount = book.amount;
            b.categoryId = book.categoryId;
            //b.image = "https://cuongquach.com/wp-content/uploads/2019/12/lap-trinh-huong-doi-tuong-voi-java.jpg";
            b.image = book.image;
            this.context.books.Add(b);
            this.context.SaveChanges();
            return b;
        }



        public List<Book> findByCategory(int categoryId)
        {
            return  this.context.books.Where(b => b.categoryId == categoryId).ToList();
        }

        public List<Book> GetAll()
        {
            var bookList = this.context.books
                .OrderByDescending(b => b.id)  // Sắp xếp giảm dần theo id
                .Select(b => new Book
                {
                    id = b.id,
                    name = b.name,
                    price = b.price,
                    amount = b.amount,
                    categoryId = b.categoryId,
                    description = b.description,
                    author = b.author,
                    image = b.image,
                    category = b.category
                });

            return bookList.ToList();
        }


        public Book getById(int id)
        {
            var book = (Book)this.context.books.FirstOrDefault(b => b.id == id);

            if (book != null)
            {
                return book;
            }
            else
            {
                return null;
            }
        }

        public List<Book> pagination(int page, int pagesize)
        {
            var book = this.context.books.OrderBy(b => b.id).Skip((page - 1) * pagesize).Take(pagesize);
            return book.ToList();
        }

        void BookRepository.delete(int id)
        {
            var book = this.context.books.SingleOrDefault(b => b.id == id);
            if(book != null)
            {
                this.context.Remove(book);
                this.context.SaveChanges();
            }
        }


        List<Book> BookRepository.search(string search)
        {
            throw new NotImplementedException();
        }

        void BookRepository.update(int id, BookDTO bookDTO)
        {
            var book = this.context.books.SingleOrDefault(b => b.id == id);
            if(book != null)
            {
                book.name = bookDTO.name;
                book.author = bookDTO.author;
                book.price = bookDTO.price;
                book.description = bookDTO.description;
                // book.image = "https://images.nxbxaydung.com.vn/Picture/2020/biasach-0626100809.jpg";
                book.image = bookDTO.image;
                book.amount = bookDTO.amount;
                book.categoryId = bookDTO.categoryId;
                this.context.books.Update(book);
                this.context.SaveChanges();
            }
        }
    }
}
