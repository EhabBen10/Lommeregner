using LommeRegner;

namespace CalculatorTest;

public class CalculatorUnitTests
{
    private Calculator Calculator;
    [SetUp]
    public void Setup()
    {
        Calculator = new Calculator();
    }

    [TestCase(2,2,4)]
    [TestCase(2, 3, 5)]
    [TestCase(-2, 3, 1)]
    public void Add_Test(double a, double b, double resulte)
    {

        Assert.That(Calculator.Add(a, b), Is.EqualTo(resulte));
    }
    [TestCase(2, 1, 1)]
    [TestCase(2, 3, -1)]
    [TestCase(-2, 3, -5)]
    public void Subtract_Test(double a, double b, double resulte)
    {

        Assert.That(Calculator.Subtract(a, b), Is.EqualTo(resulte));
    }

    [TestCase(2, 2, 4)]
    [TestCase(2, 3, 6)]
    [TestCase(-2, 3, -6)]
    public void Multiply_Test(double a, double b, double resulte)
    {

        Assert.That(Calculator.Multiply(a, b), Is.EqualTo(resulte));
    }
    [TestCase(2, 2, 4)]
    [TestCase(2, 3, 8)]
    [TestCase(-2, 3, -8)]
    public void Power_Test(double a, double b, double resulte)
    {

        Assert.That(Calculator.Power(a, b), Is.EqualTo(resulte));
    }

}
