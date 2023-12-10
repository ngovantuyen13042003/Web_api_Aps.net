using BookStore.dto;
using BookStore.Model;

namespace BookStore.repository
{
    public interface BookRepository
    {
        List<Book> GetAll();

        List<Book> search(String search);
        Book getById(int id);
        Book add(BookDTO book);
        void update(int id, BookDTO book);
        void delete(int id);

        List<Book> findByCategory(int categoryId);
    }
}
