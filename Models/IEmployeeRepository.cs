using System.Collections.Generic;

namespace Employee.Management.dotnet3.Models {
  public interface IEmployeeRepository {
    Employee GetEmployee(int id);
    IEnumerable<Employee> GetAll();
  }
}
