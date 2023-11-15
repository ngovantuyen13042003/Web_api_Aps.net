using BookStore.Model;

namespace BookStore.repository
{
    public interface CustomerRepository
    {
        Customer register(String username,String password);

        Customer login(String username, String password);
    }
}
