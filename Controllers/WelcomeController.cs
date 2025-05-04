using Employee.Management.dotnet3.Models;
using Employee.Management.dotnet3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Management.dotnet3.Controllers {
  [Route("[controller]/[action]")]
  public class WelcomeController : Controller {

    private readonly IEmployeeRepository _employeeRepository;

    public WelcomeController(IEmployeeRepository employeeRepository) {
      _employeeRepository = employeeRepository;
    }

    [Route("/")]
    public ViewResult Index() {
      var model =  _employeeRepository.GetAll();
      return View("~/Views/Home/Index.cshtml",model);
    }

    [Route("{id?}")]
    public ViewResult Details(int? id) {
      var viewModel = new HomeDetailsViewModel {
        employee = _employeeRepository.GetEmployee(id ?? 1),
        MyKeyTitle = "Hello world from viewModel value"
      };
      return View("~/Views/Home/details.cshtml",viewModel);
    }
  }
}
