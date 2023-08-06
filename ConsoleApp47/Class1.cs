﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Class1
    {

        public struct ComplexNumber
        { 
            public double Real { get; }
            public double Imaginary { get; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
            public override string ToString() => $"({Real} {(Imaginary < 0 ? "-" : "+")}{Math.Abs(Imaginary)}i)";

            public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
            {
                return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
            }

            public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
            {
                return new ComplexNumber(x.Real - y.Real, x.Imaginary + y.Imaginary);
            }

            public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
            {
                return new ComplexNumber(x.Real * y.Real - x.Imaginary * y.Imaginary, x.Real * y.Imaginary + y.Real * x.Imaginary);
            }




            }
        }

}