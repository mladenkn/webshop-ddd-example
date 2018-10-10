﻿using System.Collections.Generic;

namespace WebShop.Baskets
{
    public class Basket
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public IReadOnlyCollection<BasketItem> Items { get; set; }

        /// <summary>  
        ///  Can be null.
        /// </summary>  
        public User User { get; set; }

        /// <summary>  
        ///  Needs initialization from IModelInitializer
        /// </summary> 
        public decimal TotalPrice { get; set; }
    }
}
