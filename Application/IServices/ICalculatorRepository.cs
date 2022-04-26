namespace Application.IServices
{
    public interface ICalculatorRepository
    {
        double Addition(double num1, double num2);
        double Multiplication(double num1, double num2);
        double Division(double num1, double num2);
        double Subtraction(double num1, double num2);
    }
}
