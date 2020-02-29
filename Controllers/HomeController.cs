using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAspNetWebApplication2._2.Models;

namespace TestAspNetWebApplication2._2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			//this is just a comment to test the github .netcore build actions.
			//Create the solution, add it to source control, publish it to github, work on a freemind mind map to get this all straight in your head
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
