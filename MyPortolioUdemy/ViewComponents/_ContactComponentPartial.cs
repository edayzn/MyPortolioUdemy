using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { 
            MyPortfolioContext context = new MyPortfolioContext();
            var values=context.Contacts.ToList();
            return View(values); }
    }
}
