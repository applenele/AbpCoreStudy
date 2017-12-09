using Microsoft.AspNetCore.Antiforgery;
using AbpCoreStudy.Controllers;

namespace AbpCoreStudy.Web.Host.Controllers
{
    public class AntiForgeryController : AbpCoreStudyControllerBase
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
