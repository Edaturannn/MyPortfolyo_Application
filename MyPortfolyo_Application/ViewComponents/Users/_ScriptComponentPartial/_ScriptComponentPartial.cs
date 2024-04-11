using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Users._FeatureComponentPartial
{
    public class _ScriptComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
