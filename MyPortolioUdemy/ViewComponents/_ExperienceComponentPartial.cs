using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
