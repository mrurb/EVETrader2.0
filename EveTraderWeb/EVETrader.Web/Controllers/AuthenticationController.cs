using EVETrader.Web.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EVETrader.Web.Controllers
{
    public class AuthenticationController : Controller
    {
		[HttpGet("~/signin")]
		public async Task<IActionResult> SignIn() => View("SignIn", await HttpContext.GetExternalProvidersAsync());

		[HttpPost("~/signin")]
		public async Task<IActionResult> SignIn([FromForm] string provider)
		{
			if (string.IsNullOrWhiteSpace(provider))
			{
				return BadRequest();
			}

			if (!await HttpContext.IsProviderSupportedAsync(provider))
			{
				return BadRequest();
			}

			return Challenge(new AuthenticationProperties { RedirectUri = "/" }, provider);
		}


		[HttpGet("~/signout"), HttpPost("~/signout")]
		public IActionResult SigOut()
		{
			return SignOut(new AuthenticationProperties { RedirectUri = "/" }, CookieAuthenticationDefaults.AuthenticationScheme);
		}
	}
}