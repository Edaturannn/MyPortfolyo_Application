using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;

namespace MyPortfolyo_Application.Controllers
{
    public class AdminsController : Controller
    {
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
        {
            ViewBag.AboutCount = context.Abouts.Count();
            ViewBag.ContactCount = context.Contacts.Count();
            ViewBag.FeatureCount = context.Features.Count();
            ViewBag.MessageCount = context.Messages.Count();
            ViewBag.PortfolioCount = context.Portfolios.Count();
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.SocialMediaCount = context.SocialMedias.Count();
            ViewBag.TestimonialCount = context.Testimonials.Count();
            ViewBag.ToDoListCount = context.ToDoLists.Count();
            ViewBag.WorkExperienceCount = context.WorkExperiences.Count();
			return View();
        }
    }
}
