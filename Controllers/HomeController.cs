using Employee.Management.dotnet3.Models;
using Employee.Management.dotnet3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Management.dotnet3.Controllers {
  public class HomeController : Controller {
    private readonly IEmployeeRepository _employeeRepository;

    public HomeController(IEmployeeRepository employeeRepository) {
      _employeeRepository = employeeRepository;
    }

    public ViewResult Index() {
      var model =  _employeeRepository.GetAll();
      return View(model);
    }

    public ViewResult Details(int id) {
      var viewModel = new HomeDetailsViewModel {
        Employee = _employeeRepository.GetEmployee(id),
        MyKeyTitle = "Hello world from viewModel value"
      };
      return View(viewModel);
    }
  }
}
