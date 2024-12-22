using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {  return View(); }

    }
}
