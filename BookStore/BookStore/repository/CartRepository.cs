﻿using BookStore.dto;
using BookStore.Model;

namespace BookStore.repository
{
    public interface CartRepository
    {
        List<Cart> GetAll();
        Cart add(CartDTO cartDTO);
        void update(int id);
        void delete(int id);
    }
}
