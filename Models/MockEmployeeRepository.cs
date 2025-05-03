using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Employee.Management.dotnet3.Models {
  public class MockEmployeeRepository : IEmployeeRepository {
    private List<EmployeeModel> _employees;

    public MockEmployeeRepository()
    {
      _employees = new List<EmployeeModel> {
        new EmployeeModel { Id = 1, Name = "Parth", Department = "HR", Email = "Parth@Eleven11.com" },
        new EmployeeModel { Id = 2, Name = "Tilva", Department = "IT", Email = "Tilva@Eleven11.com" },
        new EmployeeModel { Id = 3, Name = "Lion", Department = "IT", Email = "Lion@Eleven11.com" },
      };
    }

    public IEnumerable<EmployeeModel> GetAll() {
      return _employees;
    }

    public EmployeeModel GetEmployee(int id) {
      return _employees.FirstOrDefault(e => e.Id == id);
    }
  }
}
