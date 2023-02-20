using KKCarpoolMNGMNT.Models;

namespace KKCarpoolMNGMNT.Interfaces
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetEmployees();
    }
}
