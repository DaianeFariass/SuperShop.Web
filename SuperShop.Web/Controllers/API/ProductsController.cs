using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Web.Data;

namespace SuperShop.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _product;

        public ProductsController(IProductRepository product)
        {
            _product = product;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_product.GetAllWithUsers());
        }
    }
}
