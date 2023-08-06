using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the real part of complex number x:");
            double realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter the Imaginary part of complex number x:");
            double imaginaryPart = double.Parse(Console.ReadLine());
            var x = new Class1.ComplexNumber(realPart, imaginaryPart);

            Console.Write("\nEnter the real part of complex number y:");
            realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of complex number y:");
            imaginaryPart = double.Parse(Console.ReadLine());
            var y = new Class1.ComplexNumber(realPart, imaginaryPart);

            Console.WriteLine();
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.WriteLine($"{x}-{y}={x - y}");
            Console.WriteLine($"{x}*{y}={x * y}");
            Console.ReadLine();
        }
    }
}
