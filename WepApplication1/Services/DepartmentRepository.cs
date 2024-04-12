using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //Day8dbContext Context;//= new Day8dbContext();
        List<Department> Context = new List<Department>();
        //public DepartmentRepository (Day8dbContext _Context)
        //{
        //    Context = _Context;
        //}
        public void Add(Department department)
        {
            Context.Add(department);
            //Context.SaveChanges();
        }
        public List<Department> All()
        {
            return Context.ToList();
        }
    }
}
