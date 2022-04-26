namespace Calculator.Infrastructure
{
    public abstract class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
       	protected ILogger Logger { get; }
        protected Application.IServices.ICalculatorRepository CalculatorRepository { get; }

        protected Controller(ILogger logger, Application.IServices.ICalculatorRepository calculatorRepository) : base()
        {
            Logger = logger;
            CalculatorRepository = calculatorRepository;
        }
    }
}