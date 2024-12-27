using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;
using MyPortolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class SocialMediaController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult SocialMediaList()
		{
			var value=context.SocialMedias.ToList();
			return View(value);
		}
		public IActionResult CreateSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(value);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
	}
}
