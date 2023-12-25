using BookStore.dto;
using BookStore.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.repository
{
    public interface BookRepository
    {
        List<Book> GetAll();

        Book getById(int id);
        Book add(BookDTO book);
        void update(int id, BookDTO book);
        void delete(int id);

        List<Book> findByCategory(int categoryId);

        List<Book> Search(string search);

        List<Book> pagination(int page, int pagesize);
    }
}
