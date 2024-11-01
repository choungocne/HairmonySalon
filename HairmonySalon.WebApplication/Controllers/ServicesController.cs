using Microsoft.AspNetCore.Mvc;

namespace HairHarmonySalon.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Appointment()
		{
			return View();
		}
		public IActionResult PickTime()
		{
			return View();
		}

		public IActionResult SelectStylist()
		{
			return View();
		}

	}
}
