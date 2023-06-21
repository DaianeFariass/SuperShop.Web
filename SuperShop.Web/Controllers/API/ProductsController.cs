using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Web.Data;

namespace SuperShop.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
