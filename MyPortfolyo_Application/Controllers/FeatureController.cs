using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Application.DAL.Context;
using MyPortfolyo_Application.DAL.Entities;

namespace MyPortfolyo_Application.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Features.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature p)
        {
            context.Features.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature p)
        {
            context.Features.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFeature(int id)
        {
            var values = context.Features.Find(id);
            context.Features.Remove(values);
            context.SaveChanges();
            return View("Index");
        }
    }
}
