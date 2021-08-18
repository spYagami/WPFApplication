﻿using System;

namespace Calculator_Model
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Add()
        {
            return Num1 + Num2;
        }
        public double Subtract()
        {
            return Num1 - Num2;
        }

        public double Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            return Num2 == 0 ? throw new ArgumentException("Can't divide by zero") : Num1 / Num2;
        }

    }
}
