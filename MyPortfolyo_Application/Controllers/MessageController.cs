using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values=context.Messages.ToList();
            return View(values);
        }

        public IActionResult UpdateMessage(int id)
        {
            var values = context.Messages.Find(id);
            if (values.IsRead=="Okundu")
            {
                values.IsRead = "Okunmadı";
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else if (values.IsRead == "Okunmadı")
            {
                values.IsRead = "Okundu";
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
