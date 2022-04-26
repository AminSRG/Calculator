using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculator.Controllers
{
    public class HomeController : Calculator.Infrastructure.Controller
    {
        public HomeController(ILogger<HomeController> logger,
            Application.IServices.ICalculatorRepository calculatorRepository) : base(logger, calculatorRepository)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Domain.Model.Operation operation)
        {
            switch (operation.OperationType)
            {
                case Domain.Enum.OperationType.Addition: 
                    operation.Result = CalculatorRepository.Addition(operation.Num1, operation.Num2);
                    break;
                case Domain.Enum.OperationType.Multiplication:
                    operation.Result = CalculatorRepository.Multiplication(operation.Num1, operation.Num2);
                    break;
                case Domain.Enum.OperationType.Division: 
                    operation.Result = CalculatorRepository.Division(operation.Num1, operation.Num2);
                    break;
                case Domain.Enum.OperationType.Subtraction: 
                    operation.Result = CalculatorRepository.Subtraction(operation.Num1, operation.Num2);
                    break;
            }
            return View(model: operation);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}