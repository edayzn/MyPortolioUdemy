using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext contex= new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var value=contex.Messages.ToList();
			return View(value);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value= contex.Messages.Find(id);
			value.IsRead=true;
			contex.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = contex.Messages.Find(id);
			value.IsRead = false;
			contex.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = contex.Messages.Find(id);
			contex.Messages.Remove(value);
			contex.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetail(int id)
		{
			var value=contex.Messages.Find(id);
			return View(value);
		}
	}
}
