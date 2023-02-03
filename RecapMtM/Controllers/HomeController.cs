using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Recap.Controllers;

public class HomeController : Controller
{

	public HomeController()
	{
	}

	public IActionResult Index()
	{
		return View();
	}
}
