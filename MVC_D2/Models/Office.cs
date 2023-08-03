using Microsoft.EntityFrameworkCore;

namespace MVC_D2.Models
{
    [PrimaryKey("Id")]
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //NAVIGATOR
        public List<Employee> employees { get; set; }
    }
}
