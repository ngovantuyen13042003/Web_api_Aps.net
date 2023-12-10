using BookStore.Data;
using BookStore.dto;
using BookStore.Model;
using System.Collections.Generic;

namespace BookStore.repository.repositoryImpl
{
    public class CartRepositoryImpl : CartRepository
    {
        private readonly DataContext context;

        public CartRepositoryImpl(DataContext context)
        {
            this.context = context;
        }

        public Cart add(CartDTO cartDTO)
        {
            Cart cart = new Cart();
            cart.BookName = cartDTO.BookName;
            cart.bookId = cartDTO.bookId;
            cart.customerId = cartDTO.customerId;
            cart.Price = cartDTO.Price;
            cart.Amount = cartDTO.Amount;
            cart.Author = cartDTO.Author;

            this.context.carts.Add(cart);
            this.context.SaveChanges();
            return cart;
        }

        public void delete(int id)
        {
            var cart = this.context.carts.SingleOrDefault(c => c.IdCart == id);
            if(cart != null)
            {
                this.context.carts.Remove(cart);
                this.context.SaveChanges();
            }
        }

        public List<Cart> GetAll()
        {
            var carts = this.context.carts.Select(cart => new Cart
            {
                IdCart = cart.IdCart,
                BookName = cart.BookName,
                Amount = cart.Amount,
                Author = cart.Author,
                bookId = cart.bookId,
                customerId = cart.customerId,
                Price = cart.Price
            });
            return carts.ToList();
        }

        public void update(int id)
        {
            var cart = this.context.carts.SingleOrDefault(c => c.IdCart == id);
            if(cart != null)
            {
                cart.Amount = cart.Amount + 1;
                cart.Price = (cart.Price + cart.Price);
                this.context.carts.Update(cart);
                this.context.SaveChanges();
            }
        }
    }
}
