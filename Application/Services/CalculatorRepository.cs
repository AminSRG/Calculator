namespace Application.Services
{
    public class CalculatorRepository : IServices.ICalculatorRepository
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
