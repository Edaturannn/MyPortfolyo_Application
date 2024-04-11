using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutNavbarMessageComponentPartial
{
    public class _LayoutNavbarMessageComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
    }
}
