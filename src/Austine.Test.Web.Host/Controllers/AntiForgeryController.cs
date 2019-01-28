using Microsoft.AspNetCore.Antiforgery;
using Austine.Test.Controllers;

namespace Austine.Test.Web.Host.Controllers
{
    public class AntiForgeryController : TestControllerBase
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
