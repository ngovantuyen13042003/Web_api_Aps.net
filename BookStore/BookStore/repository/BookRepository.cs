using BookStore.dto;
using BookStore.Model;

namespace BookStore.repository
{
    public interface BookRepository
    {
        List<BookDTO> GetAll();

        List<BookDTO> search(String search);
        BookDTO getById(int id);
        BookDTO add(BookDTO book);
        void update(BookDTO book);
        void delete(int id);
    }
}
