using LommeRegner;

Calculator calculator = new Calculator();


Console.WriteLine("Testing Add class");

Console.WriteLine($"The sum of 4 + 4 is {calculator.Add(4,4)}");
Console.WriteLine("If the ansawer was 8 then the test works");


Console.WriteLine("Testing Subtract class");

Console.WriteLine($"The sum of 8 - 4 is {calculator.Subtract(8, 4)}");
Console.WriteLine("If the ansawer was 4 then the test works");



Console.WriteLine("Testing Multiply class");

Console.WriteLine($"The sum of 8 * 4 is {calculator.Multiply(8, 4)}");
Console.WriteLine("If the ansawer was 32 then the test works");


Console.WriteLine("Testing Power class");

Console.WriteLine($"The sum of 8 ^ 4 is {calculator.Power(8, 4)}");
Console.WriteLine("If the ansawer was 4096 then the test works");


Console.ReadLine();