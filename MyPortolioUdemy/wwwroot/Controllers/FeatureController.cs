using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;
using MyPortolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult FeatureList()
		{
			var value=context.Features.ToList();
			return View(value);
		}
		public IActionResult CreateFeature()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateFeature(Feature feature)
		{
			context.Features.Add(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
		public IActionResult DeleteFeature(int id)
		{
			var value = context.Features.Find(id);
			context.Features.Remove(value);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
		[HttpGet]
		public IActionResult UpdateFeature(int id)
		{
			var value = context.Features.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateFeature(Feature feature)
		{
			context.Features.Update(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
	}
}
