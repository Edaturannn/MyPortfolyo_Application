using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Users._AboutComponentPartial
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
