using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SuperShop.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile simageFile, string folder);
    }
}
