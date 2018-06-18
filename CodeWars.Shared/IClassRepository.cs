using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeWars.Shared
{
    public interface IClassRepository
    {
        Task<Class> GetClass(int id);
        Task<IEnumerable<Class>> GetClasses();
        int AddClass(Class cls);
        int UpdateClass(Class prod);
        int DeleteClass(int id);
        int CreateClassTable();
    }
}
