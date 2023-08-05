using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class ProjectController : Controller
    {
        DataContext context;
        public ProjectController()
        {
            context = new DataContext();
        }
        public IActionResult Index()
        {
            List<Project> projects= context.project.ToList();
            return View(projects);
        }
        public IActionResult Details(int id)
        {
            Project project = context.project.SingleOrDefault(p => p.Id == id);
            if (project == null)
            {
                return Content("Error");
            }
            return View(project);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Project project) {
            context.project.Add(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Project proj = context.project.SingleOrDefault(p=>p.Id == id);
            return View(proj);
        }
        [HttpPost]
        public IActionResult Edit(Project proj)
        {
            Project Oldproject= context.project.SingleOrDefault(p=>p.Id == proj.Id);
            Oldproject.Name= proj.Name;
            Oldproject.Description= proj.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Project project= context.project.SingleOrDefault(project=>project.Id == id);
            context.project.Remove(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
