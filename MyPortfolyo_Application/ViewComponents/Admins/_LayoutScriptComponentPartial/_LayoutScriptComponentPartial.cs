using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutScriptComponentPartial
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
