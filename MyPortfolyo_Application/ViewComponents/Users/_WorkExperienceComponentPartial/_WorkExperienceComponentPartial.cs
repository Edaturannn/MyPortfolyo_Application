using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Users._WorkExperienceComponentPartial
{
    public class _WorkExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = context.WorkExperiences.ToList();
            return View(values);
        }
    }
}
