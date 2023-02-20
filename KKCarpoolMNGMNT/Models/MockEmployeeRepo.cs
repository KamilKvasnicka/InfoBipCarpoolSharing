using KKCarpoolMNGMNT.Interfaces;

namespace KKCarpoolMNGMNT.Models
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        public IEnumerable<Employee> Employees => new List<Employee>
        {            
            new Employee { Id = 0, Name = "Martina Dlha", IsDriver = true },
            new Employee { Id = 1, Name = "Petra Kratka", IsDriver = true },
            new Employee { Id = 2, Name = "Jozef Skory", IsDriver = true },
            new Employee { Id = 3, Name = "Peter Stastny", IsDriver = true },
            new Employee { Id = 4, Name = "Jan Kamensky", IsDriver = true },
            new Employee { Id = 5, Name = "Igor Petroviansky", IsDriver = false },
            new Employee { Id = 6, Name = "Martin Vrbiar", IsDriver = true },
            new Employee { Id = 7, Name = "Petra Smatanova", IsDriver = false },
            new Employee { Id = 8, Name = "Ivana Petrus", IsDriver = true },
            new Employee { Id = 9, Name = "Jozef Plostica", IsDriver = false },
            new Employee { Id = 10, Name = "Erik Breznen", IsDriver = true },
            new Employee { Id = 11, Name = "Filip Breznen", IsDriver = false },
            new Employee { Id = 12, Name = "Milan Kerek", IsDriver = true },
            new Employee { Id = 13, Name = "Peter Kusnier", IsDriver = false },
            new Employee { Id = 14, Name = "Alex Molcan", IsDriver = true },
            new Employee { Id = 15, Name = "Marco Schwarz", IsDriver = true },
            new Employee { Id = 16, Name = "Radovan Grac", IsDriver = true },
            new Employee { Id = 17, Name = "Patrik Molcan", IsDriver = true },
            new Employee { Id = 18, Name = "Lenka Lozna", IsDriver = true },
            new Employee { Id = 19, Name = "Tomas Damian", IsDriver = true },
            new Employee { Id = 20, Name = "Michal Biely", IsDriver = true },
            new Employee { Id = 21, Name = "Peter Pavol", IsDriver = true },
            new Employee { Id = 22, Name = "Marta Martakova", IsDriver = false },
            new Employee { Id = 23, Name = "Lubomir Kus", IsDriver = true },
            new Employee { Id = 24, Name = "Richard Molnar", IsDriver = false }
        };

        public IEnumerable<Employee> GetEmployees()
        {
            return Employees;
        }
    }
}
