using BookStore.dto;
using BookStore.Model;

namespace BookStore.mapper
{
    public class CartMapper
    {
        public static Cart toCart(CartDTO cartDTO)
        {
            Cart cart = new Cart();
            cart.bookId = cartDTO.bookId;
            cart.customerId = cartDTO.customerId;
            cart.Price = cartDTO.Price;
            cart.Amount = cartDTO.Amount;
            cart.Author = cartDTO.Author;
            cart.BookName = cartDTO.BookName;
            cart.totalPrice = cartDTO.totalPrice;
            cart.totalQuantity = cartDTO.totalQuantity;
            return cart;
        }
    }
}
