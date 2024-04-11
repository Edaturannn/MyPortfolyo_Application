using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Users._StatisticComponentPartial
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
