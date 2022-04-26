using AutoMapper;
using Calculator.Models;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Persistence.ViewModel;
using System.Diagnostics;

namespace Calculator.Controllers
{
    public class HomeController : Calculator.Infrastructure.Controller
    {
        public HomeController(ILogger<HomeController> logger,
            Application.IServices.ICalculatorRepository calculatorRepository, IMapper mapper) : base(logger, mapper, calculatorRepository)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OperationViewModel operationViewModel)
        {
            var operation = Mapper.Map<Operation>(operationViewModel);
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
            var operationResult = Mapper.Map<OperationViewModel>(operation);
            return View(model: operationResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}