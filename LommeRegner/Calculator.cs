using System;
namespace LommeRegner
{
	public class Calculator
	{
        public double Accumulator { get; private set; } = 1;
        public Calculator()
		{
		}

		public double Add(double b)
		{
            Accumulator = Accumulator + b;

            return Accumulator;
		}

        public double Subtract(double b)
        {
            Accumulator = Accumulator - b;
            return Accumulator;
        }

        public double Multiply(double b)
        {
            Accumulator = Accumulator * b;
            return Accumulator;
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public double Divide(double b)
        {
            Accumulator = Accumulator / b;
            return Accumulator ;
        }

        public void clear()
        {
            Accumulator = 0;
        }

    }
}

