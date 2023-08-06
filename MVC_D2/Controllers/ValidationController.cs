using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_D2.Models;
using MVC_D2.ViewModel;

namespace MVC_D2.Controllers
{
   
    public class ValidationController : Controller
    {
        DataContext context;
        public ValidationController()
        {
            context = new DataContext();
        }
        [HttpGet]
        public IActionResult add()
        {
            AddEmpView addEmpView = new AddEmpView() { Offices = new SelectList(context.office.ToList(), "Id", "Name") };

            return View(addEmpView);
        }
        [HttpPost]
        public IActionResult add(AddEmpView addEmpView)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.Id = addEmpView.Id;
                employee.Name = addEmpView.Name;
                employee.Salary = addEmpView.Salary;
                employee.Age = addEmpView.Age;
                employee.Email = addEmpView.Email;
                employee.Password = addEmpView.Password;
                employee.Off_Id = addEmpView.Off_Id;
                context.employee.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                addEmpView.Offices = new SelectList(context.office.ToList(), "Id", "Name");
                return View(addEmpView);
            }
        }






    }
}
