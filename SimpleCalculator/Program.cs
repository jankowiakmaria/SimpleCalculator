﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.Calculate("+", 5);
        }
    }
}

//Requirements (possible operations):
//Add (+)                   +
//Subtract (-)              +
//Multiply (*)              
//Divide (/)                
//Clear (0)                 
//Change sign (+/-)         
//Sqrt                      