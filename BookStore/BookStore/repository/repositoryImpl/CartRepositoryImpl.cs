using BookStore.Data;
using BookStore.dto;
using BookStore.mapper;
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
            var cart =  this.context.carts.SingleOrDefault(c => c.bookId == cartDTO.bookId);
            if(cart == null)
            {
                cart = CartMapper.toCart(cartDTO);
                cart.totalQuantity = 1;
                cart.totalPrice = cartDTO.Price;
                this.context.carts.Add(cart);
            }
            else
            {
                cart.totalQuantity = cart.totalQuantity +cartDTO.totalQuantity ;
                cart.totalPrice = cartDTO.Price * cartDTO.totalQuantity;
                this.context.carts.Update(cart);
            }

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
                Price = cart.Price,
                totalQuantity  = cart.totalQuantity,
                totalPrice = cart.totalPrice
            });
            return carts.ToList();
        }
     
    }
}
