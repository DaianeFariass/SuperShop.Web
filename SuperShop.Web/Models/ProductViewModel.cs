using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SuperShop.Web.Data.Entities;


namespace SuperShop.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name= "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
