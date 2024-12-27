using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext context = new MyPortfolioContext();
            var values=context.Testimonials.ToList();
            return View(values); 
        }
    }
}
