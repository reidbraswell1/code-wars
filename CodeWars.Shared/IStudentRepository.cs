using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeWars.Shared
{
    public interface IStudentRepository
    {
        Task<Student> GetStudent(int id);
        Task<IEnumerable<Student>> GetStudents();
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
        int CreateStudentTable();
    }
}
