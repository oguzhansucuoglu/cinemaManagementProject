using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DepartmentModel
    {
        [Key]
        public Int32 Id { get; set; }
        public string? name { get; set; }    
        public string? managerName { get; set; }
        public DepartmentModel() { }
        public DepartmentModel(Int32 Id, string name, string managerName)
        {
            //this.Id = Id;
            this.name = name;
            this.managerName = managerName;
        }
    }
}
