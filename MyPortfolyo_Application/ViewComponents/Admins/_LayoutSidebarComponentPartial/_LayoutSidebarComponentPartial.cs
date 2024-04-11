using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutSidebarComponentPartial
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
