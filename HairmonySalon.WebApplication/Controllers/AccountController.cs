using Microsoft.AspNetCore.Mvc;

namespace HairHarmonySalon.Controllers
{
	public class Account : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
