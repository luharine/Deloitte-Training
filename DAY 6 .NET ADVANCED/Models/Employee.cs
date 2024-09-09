using Microsoft.EntityFrameworkCore;

namespace EmployeeMgmt.Models
{
    
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string job {  get; set; }

        public int Salary { get; set; }

        public string Department {  get; set; }
       
    }

    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

    }



    public class EmployeeDbContext : DbContext {

        public DbSet<Employee>  Employees { get; set; }

        public DbSet<User> Users { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): base(options){
}

    }
}
