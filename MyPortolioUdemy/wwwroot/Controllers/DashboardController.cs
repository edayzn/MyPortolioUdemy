using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.Controllers
{
	public class DashboardController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Dashboard()
		{
			//var value = context.Skills.ToList();
			//ViewBag.Value = context.ToDoLists.ToList();
			return View();
		}
	}
}
