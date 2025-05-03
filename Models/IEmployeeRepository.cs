using System.Collections.Generic;

namespace Employee.Management.dotnet3.Models {
  public interface IEmployeeRepository {
    EmployeeModel GetEmployee(int id);
    IEnumerable<EmployeeModel> GetAll();
  }
}
