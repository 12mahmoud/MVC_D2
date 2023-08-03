﻿using Microsoft.AspNetCore.Mvc;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class EmployeeController : Controller
    {
        DataContext context;
        public EmployeeController()
        {
            context = new DataContext();
        }

        public IActionResult Index()
        {
            List<Employee> employees = context.employee.ToList();
            return View(employees);
        }
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult AddToDB(Employee employee) {
            try
            {
                context.employee.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex) { return Content(ex.Message); }    
        }
        public IActionResult Delete(int id)
        {
            try
            {
                Employee employee = context.employee.SingleOrDefault(e => e.Id == id);
                context.employee.Remove(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }catch(Exception ex) { return Content(ex.Message); };
        }
        public IActionResult EditForm(int id) { 
            Employee employee=context.employee.SingleOrDefault(e=>e.Id == id);
            return View(employee);
        }
        public IActionResult EditDB(Employee employee)
        {
            Employee OldEmployee=context.employee.SingleOrDefault(e=>e.Id == employee.Id);
            OldEmployee.Name=employee.Name; 
            OldEmployee.Email=employee.Email;
            OldEmployee.Salary=employee.Salary;
            OldEmployee.Password=employee.Password;
            OldEmployee.Age=employee.Age;

            
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Details(int id)
        {
            Employee employee=context.employee.SingleOrDefault(e=>e.Id == id);
            if (employee == null)
            {
                return Content("Error");
            }
            return View(employee);
        } 
             
        
    }
}