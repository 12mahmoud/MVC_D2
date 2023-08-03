using Microsoft.EntityFrameworkCore;

namespace MVC_D2.Models
    
{
    [PrimaryKey("Id")]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //navigators
        public List<Emp_proj> emp_Projs { get; set; }
    }
}
