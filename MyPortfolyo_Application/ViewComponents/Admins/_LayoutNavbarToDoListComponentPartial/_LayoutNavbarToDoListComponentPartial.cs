using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutNavbarToDoListComponentPartial
{
    public class _LayoutNavbarToDoListComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
    }
}
