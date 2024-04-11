using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.ViewComponents.Admins._LayoutNavbarComponentPartial
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.MessageCount = context.Messages.Count();
            ViewBag.ToDoListCount = context.ToDoLists.Count();
            return View();
        }
    }
}
