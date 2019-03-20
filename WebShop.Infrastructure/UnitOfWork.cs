﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess;

namespace WebShop.Infrastructure.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebShopDbContext _dbContext;

        public UnitOfWork(WebShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(object o) => _dbContext.Add(o);

        public void Update(object o) =>_dbContext.Update(o);

        public void Delete(object o) => _dbContext.Remove(o);

        public Task PersistChanges() => _dbContext.SaveChangesAsync();
    }
}