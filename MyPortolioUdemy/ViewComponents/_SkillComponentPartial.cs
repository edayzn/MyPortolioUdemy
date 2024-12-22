using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
