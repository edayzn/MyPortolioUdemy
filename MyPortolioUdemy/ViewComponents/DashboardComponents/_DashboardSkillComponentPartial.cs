using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents.DashboardComponents
{
    public class _DashboardSkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();    
        public IViewComponentResult Invoke()
        {
           var value=context.Skills.ToList();
            return View(value);
        }
    }
}
