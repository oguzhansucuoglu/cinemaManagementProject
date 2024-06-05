namespace WebApplication1.Models
{
    public class EmployeeModel
    {
        public Int32 Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double Salary { get; set; }
        public static List<EmployeeModel> GetList()
        {
            List<EmployeeModel> Employees = new List<EmployeeModel>
            {
                new EmployeeModel { Id = 1, FirstName = "Rahul", LastName ="Kumar", Salary=45000},
                new EmployeeModel { Id = 2, FirstName ="Jose", LastName = "Mathews", Salary = 25000},
                new EmployeeModel { Id = 3, FirstName ="Ajith", LastName="Kumar", Salary=25000},
                new EmployeeModel { Id = 4, FirstName ="Scott", LastName="Allen", Salary=35000},
                new EmployeeModel { Id = 5, FirstName ="Abhishek", LastName="Nair", Salary=125000}
            };
            return Employees;
        }

        public static EmployeeModel Get(int Id1)
        {

            List<EmployeeModel> Employees = GetList();

            foreach (EmployeeModel employee in Employees)
            {

                    return employee;

            }
            return null;

        }
    }
}
