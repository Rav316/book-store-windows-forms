﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.entity
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public Cart(int id, int userId, int bookId, int quantity)
        {
            Id = id;
            UserId = userId;
            BookId = bookId;
            Quantity = quantity;
        }
    }
}
