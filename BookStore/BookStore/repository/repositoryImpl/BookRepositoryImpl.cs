using BookStore.Data;
using BookStore.dto;
using BookStore.Model;

namespace BookStore.repository.repositoryImpl
{
    public class BookRepositoryImpl : BookRepository
    {

        private readonly DataContext context;
        public BookRepositoryImpl(DataContext _context)
        {
            this.context = _context;
        }

        public BookDTO add(BookDTO bookDTO)
        {
            Book book = new Book();
            book.author = bookDTO.author;
            book.description = bookDTO.description;
            book.name = bookDTO.name;
            book.price = bookDTO.price;
            book.publisher = bookDTO.publisher;
            book.amount = bookDTO.amount;
            book.language = bookDTO.language;


            return null;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookDTO getById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(BookDTO book)
        {
            throw new NotImplementedException();
        }

        BookDTO BookRepository.add(BookDTO book)
        {
            throw new NotImplementedException();
        }

        void BookRepository.delete(int id)
        {
            throw new NotImplementedException();
        }

        List<BookDTO> BookRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        BookDTO BookRepository.getById(int id)
        {
            throw new NotImplementedException();
        }

        List<BookDTO> BookRepository.search(string search)
        {
            throw new NotImplementedException();
        }

        void BookRepository.update(BookDTO book)
        {
            throw new NotImplementedException();
        }
    }
}
