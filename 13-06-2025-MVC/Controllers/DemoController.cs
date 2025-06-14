using System.Diagnostics;
using _13_06_2025_MVC.Models;
using Microsoft.AspNetCore.Mvc;

public class Democontroller : Controller
{
	// host /Demo/ AAA
	public IActionResult AAA()
	{
		return Content("OK");
	}

    // host /Demo/ BBB
	public IActionResult BBB()
	{
		return Content("OK BBB");
	}

	public string ActionTest()
	{
		return "ActionTest OK";
    }
}

