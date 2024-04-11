using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Users._HeadComponentPartial
{
    public class _HeadComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
