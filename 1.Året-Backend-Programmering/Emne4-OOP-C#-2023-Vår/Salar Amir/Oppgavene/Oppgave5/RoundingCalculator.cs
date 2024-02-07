namespace Oppgave5;

public class RoundingCalculator : ICalculator
{
    public double Add(double a, double b)
    {
        return Math.Round(a + b);
    }

    public double Subtract(double a, double b)
    {
        return Math.Round(a - b);
    }

    public double Multiply(double a, double b)
    {
        return Math.Round(a * b);
    }

    public double Divide(double a, double b)
    {
        return Math.Round(a / b);
    }
}