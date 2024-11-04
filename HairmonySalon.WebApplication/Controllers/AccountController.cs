using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HairHarmonySalon.Models; 

namespace HairHarmonySalon.Controllers
{
	public class Account : Controller
	{
		public IActionResult Register()
		{
			return View();
		}
	}
}
