using Microsoft.AspNetCore.Mvc;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class OfficeController : Controller
    {
        DataContext context;
        public OfficeController()
        {
            context = new DataContext();
        }
        public IActionResult Index()
        {
            List <Office>offices = context.office.ToList(); 
            return View(offices);
        }
        public IActionResult ADDform()
        {
            return View();
        }
        public IActionResult AddToDB(Office office)
        {
            try
            {
                context.office.Add(office);
                context.SaveChanges();
                return RedirectToAction("Index");
            }catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult Edit(int id)
        {
            Office office = context.office.SingleOrDefault(o => o.Id == id);    
            return View(office);
        }
        
        public IActionResult EditInDB(Office office)
        {
            Office Oldoffice=context.office.SingleOrDefault(o =>o.Id== office.Id);
            Oldoffice.Name= office.Name;
            Oldoffice.Location= office.Location;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            try
            {
                Office office = context.office.SingleOrDefault(o => o.Id == id);
                context.office.Remove(office);
                context.SaveChanges();
                return RedirectToAction("Index");
            }catch(Exception ex) { return Content(ex.Message); }
        }
    }
}
