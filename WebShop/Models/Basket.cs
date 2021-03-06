﻿using System.Collections.Generic;

namespace WebShop.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<BasketItem> Items { get; set; }
    }
}
