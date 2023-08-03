using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    [PrimaryKey("Emp_Id", "Proj_Id")]
    public class Emp_proj
    {
        [ForeignKey("employee")]
        public int Emp_Id { get; set; }
        [ForeignKey("project")]
        public int Proj_Id { get; set; }
        public int WorkingHours { get; set; }
        //navigator
        public Employee employee { get; set; }
        public Project project { get; set; }
    }
}
