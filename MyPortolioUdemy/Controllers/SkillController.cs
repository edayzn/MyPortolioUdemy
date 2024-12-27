using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;
using MyPortolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult SkillList()
		{
			var value=context.Skills.ToList();
			return View(value);
		}
		public IActionResult CreateSkill()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
		public IActionResult DeleteSkill(int id)
		{
			var value = context.Skills.Find(id);
			context.Skills.Remove(value);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var value = context.Skills.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
	}
}
