using Employee.Management.dotnet3.Models;
using Employee.Management.dotnet3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Management.dotnet3.Controllers {
  public class HomeController : Controller {
    private readonly IEmployeeRepository _employeeRepository;

    public HomeController(IEmployeeRepository employeeRepository) {
      _employeeRepository = employeeRepository;
    }

    public string Index() {
      return _employeeRepository.GetEmployee(1).Name;
    }

    public ViewResult Details(int id) {
      var viewModel = new HomeDetailsViewModel {
        employee = _employeeRepository.GetEmployee(id),
        MyKeyTitle = "Hello world from viewModel value"
      };
      return View(viewModel);
    }
  }
}
