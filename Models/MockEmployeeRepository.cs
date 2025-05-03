using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Employee.Management.dotnet3.Models {
  public class MockEmployeeRepository : IEmployeeRepository {
    private List<Employee> _employees;

    public MockEmployeeRepository()
    {
      _employees = new List<Employee> {
        new Employee { Id = 1, Name = "Parth", Department = "HR", Email = "Parth@Eleven11.com" },
        new Employee { Id = 2, Name = "Tilva", Department = "IT", Email = "Tilva@Eleven11.com" },
        new Employee { Id = 3, Name = "Lion", Department = "IT", Email = "Lion@Eleven11.com" },
      };
    }

    public IEnumerable<Employee> GetAll() {
      return _employees;
    }

    public Employee GetEmployee(int id) {
      return _employees.FirstOrDefault(e => e.Id == id);
    }
  }
}
