using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents.DashboardComponents
{
    public class _DashboardToDoListComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value=context.ToDoLists.ToList();
            return View(value);
        }
        public IViewComponentResult ChangeToDoListStatusTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return View(value);
        }
        public IViewComponentResult ChangeToDoListStatusFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return View(value);
        }
    }
}
