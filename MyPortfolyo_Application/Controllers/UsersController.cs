using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;
using MyPortfolyo_Application.DAL.Entities;

namespace MyPortfolyo_Application.Controllers
{
    public class UsersController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message p)
        {
            p.IsRead = "Okunmadı";
            p.SendDate = DateTime.Now;
            context.Messages.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
