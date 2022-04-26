using AutoMapper;

namespace Calculator.Infrastructure
{
    public abstract class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
       	protected ILogger Logger { get; }
        protected Application.IServices.ICalculatorRepository CalculatorRepository { get; }
        protected IMapper Mapper { get; }


        protected Controller(ILogger logger, IMapper mapper,Application.IServices.ICalculatorRepository calculatorRepository) : base()
        {
            Logger = logger;
            CalculatorRepository = calculatorRepository;
            Mapper = mapper;
        }
    }
}