using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;
using MyPortolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult PortfolioList()
		{
			var value=context.Portfolios.ToList();
			return View(value);
		}
		public IActionResult CreatePortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
		public IActionResult DeletePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			context.Portfolios.Remove(value);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
	}
}
