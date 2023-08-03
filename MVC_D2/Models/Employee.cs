using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    [PrimaryKey("Id")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("office")]
        public int? Off_Id { get; set; }
        // Navigators
        public Office? office { get; set; }
        public List <Emp_proj> emp_Projs { get; set; }

    }
}
