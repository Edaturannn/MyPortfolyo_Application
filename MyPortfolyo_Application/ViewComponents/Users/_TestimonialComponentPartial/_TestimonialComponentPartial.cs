using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Users._TestimonialComponentPartial
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
