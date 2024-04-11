using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;
using MyPortfolyo_Application.DAL.Entities;

namespace MyPortfolyo_Application.Controllers
{
    public class WorkExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.WorkExperiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateWorkExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateWorkExperience(WorkExperience p)
        {
            p.SendDate = DateTime.Now;
            context.WorkExperiences.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateWorkExperience(int id)
        {
            var values = context.WorkExperiences.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateWorkExperience(WorkExperience p)
        {
            context.WorkExperiences.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteWorkExperience(int id)
        {
            var values = context.WorkExperiences.Find(id);
            context.WorkExperiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
