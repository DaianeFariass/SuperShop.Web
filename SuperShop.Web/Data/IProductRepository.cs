using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShop.Web.Data.Entities;


namespace SuperShop.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

        public IEnumerable<SelectListItem>GetComboProducts();

    }
}
