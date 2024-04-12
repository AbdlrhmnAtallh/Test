using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> All();
        void SaveD(Department d);
        public int Remove(int id);
    }
}