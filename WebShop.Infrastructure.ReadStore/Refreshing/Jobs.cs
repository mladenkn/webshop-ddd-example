﻿using System.Threading.Tasks;

namespace WebShop.Infrastructure.ReadStore.Refreshing
{
    public interface IDataRefreshJob
    {
        Task Task { get; set; }
    }

    public class RefreshBasketWithItemJob : IDataRefreshJob
    {
        public Task Task { get; set; }
        public int BasketId { get; set; }
        public int BasketItemId { get; set; }
    }
}