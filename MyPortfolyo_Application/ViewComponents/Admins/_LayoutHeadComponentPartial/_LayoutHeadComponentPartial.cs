using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutHeadComponentPartial
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
