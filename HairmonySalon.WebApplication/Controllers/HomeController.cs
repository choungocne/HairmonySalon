using HairHarmonySalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HairHarmonySalon.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult services()
		{
			return View();
		}
		public IActionResult Gallery()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Blog_Single()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}
		public ActionResult GetEmpName(int EmpId)
		{
			var employees = new[]
			{
				new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
				new { EmpId = 1, EmpName = "Hoang", Salary = 1000 },
				new { EmpId = 1, EmpName = "Hoa", Salary = 6000 },

};
			string matchEmpName = null;
			foreach (var item in employees)
			{
				if (item.EmpId == EmpId)
				{
					matchEmpName = item.EmpName;
				}
			}
				return Content(matchEmpName, "text/plain");
		}
                [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
				public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public ActionResult GetSalary(int EmpId)
		{
			string fileName = "~/bang-luong-" + EmpId + ".pdf";
			return File(fileName, "application/pdf");
		}
}
    }

