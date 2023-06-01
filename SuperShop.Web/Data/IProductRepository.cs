﻿using System.Linq;
using SuperShop.Web.Data.Entities;


namespace SuperShop.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

    }
}
