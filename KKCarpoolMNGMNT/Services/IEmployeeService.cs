using KKCarpoolMNGMNT.Models;

namespace KKCarpoolMNGMNT.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> Employees { get; }
        bool HasDriverLicense(int[] employeeIds);
        List<Employee> GetEmployeesByIds(int[] employeeIds);
        int[] GetEmployeeIds(List<Employee> employees);
    }
}
