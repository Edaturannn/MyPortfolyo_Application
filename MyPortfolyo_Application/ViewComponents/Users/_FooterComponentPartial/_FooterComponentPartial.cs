using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Users._FooterComponentPartial
{
    public class _FooterComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
