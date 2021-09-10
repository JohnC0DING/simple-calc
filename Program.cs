using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //get inputs
            Console.WriteLine("Enter value 1:");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value 2:");
            double val2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator:");
            char op = Convert.ToChar(Console.ReadLine());

            //intantiate object
            Calculator calc = new Calculator();
            //calculate and output result
            Console.WriteLine(calc.calculate(op, val1, val2));
        }
    }
}

public class Calculator
{
    public double calculate(char op, double val1, double val2)
    {
        if(op == '/')
        {
            return divide(val1, val2);
        }
        else if(op == '*')
        {
            return multiply(val1, val2);
        }
        else if(op == '+')
        {
            return add(val1, val2);
        }
        else if(op == '-')
        {
            return subtract(val1, val2);
        }
        else
        {
            Console.WriteLine("Please enter a valid operator (/, *, +, -)");
            return 0;
        }
    }

    public double divide(double val1, double val2)
    {
        return (val1 / val2);
    }

    public double multiply(double val1, double val2)
    {
        return (val1 * val2);
    }

    public double add(double val1, double val2)
    {
        return (val1 + val2);
    }

    public double subtract(double val1, double val2)
    {
        return (val1 - val2);
    }

}
