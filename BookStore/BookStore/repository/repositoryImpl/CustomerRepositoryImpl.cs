using BookStore.Data;
using BookStore.Model;

namespace BookStore.repository.repositoryImpl
{
    public class CustomerRepositoryImpl : CustomerRepository
    {
        private readonly DataContext context;
        public CustomerRepositoryImpl(DataContext context)
        {
            this.context = context;
        }
        public Customer login(string username, string password)
        {
            return this.context.customers.FirstOrDefault(c => c.username == username && c.password == password);
        }

        public Customer register(string username, string password)
        {
            Customer customer = new Customer();

            customer.username = username;
            customer.password = password;

            this.context.Add(customer);
            this.context.SaveChanges();

            return customer;
        }
    }
}
