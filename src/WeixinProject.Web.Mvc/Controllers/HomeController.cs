using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using WeixinProject.Controllers;

namespace WeixinProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WeixinProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
