﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SuperShop.Web.Data.Entities;


namespace SuperShop.Web.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id) 
        { 
            throw new System.NotImplementedException();
        
        }
       
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Um", Price = 10 });
            products.Add(new Product { Id = 1, Name = "Dois", Price = 20 });
            products.Add(new Product { Id = 1, Name = "Três", Price = 30 });
            products.Add(new Product { Id = 1, Name = "Quatro", Price = 40 });
            products.Add(new Product { Id = 1, Name = "Cinco", Price = 50 });

            return products;
        }

        public bool ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
