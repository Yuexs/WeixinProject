using Microsoft.AspNetCore.Antiforgery;
using WeixinProject.Controllers;

namespace WeixinProject.Web.Host.Controllers
{
    public class AntiForgeryController : WeixinProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
