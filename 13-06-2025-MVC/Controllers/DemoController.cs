using System.Diagnostics;
using _13_06_2025_MVC.Models;
using Microsoft.AspNetCore.Mvc;

public class DemoController : Controller
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

	public ViewResult ActionIndex()
	{
		ViewBag.MyData = "Gửi từ ActionIndex!";
        return View("MyView");
    }
    //host /Demo/MyView
    public ViewResult MyView()
	{
        ViewBag.MyData = "Gửi từ ActionTest!";
		return View("MyView");
    }
}

