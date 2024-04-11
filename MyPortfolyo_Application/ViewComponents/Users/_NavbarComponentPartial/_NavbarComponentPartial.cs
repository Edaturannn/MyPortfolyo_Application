using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Users._NavbarComponentPartial
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
