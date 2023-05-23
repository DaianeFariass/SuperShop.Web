using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperShop.Web.Data.Entities;
using System.Collections.Generic;

namespace SuperShop.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }    
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        
        
        }          
    }
}
