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

    [TestCase(2,3)]
    [TestCase(3, 4)]
    public void Add_Test(double b, double resulte)
    {

        Assert.That(Calculator.Add(b), Is.EqualTo(resulte));
    }
    [TestCase(1, 0)]
    [TestCase(3, -2)]
    public void Subtract_Test(double b, double resulte)
    {

        Assert.That(Calculator.Subtract(b), Is.EqualTo(resulte));
    }

    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(1, 1)]
    public void Multiply_Test(double b, double resulte)
    {

        Assert.That(Calculator.Multiply(b), Is.EqualTo(resulte));
    }
    [TestCase(0, 1)]
    [TestCase(1, 1)]
    public void Power_Test(double b, double resulte)
    {

        Assert.That(Calculator.Power(b), Is.EqualTo(resulte));
    }


    [TestCase(1,1)]
    [TestCase(2,0.5)]
    public void Divid_Test(double b, double resulte)
    {
        Assert.That(Calculator.Divide(b), Is.EqualTo(resulte));

    }

    public void Clear_Test()
    {
        Calculator.clear();
        Assert.That(Calculator.Accumulator, Is.EqualTo(0));

    }


}
