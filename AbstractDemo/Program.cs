using AbstractDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new ChildCalculate();
            calculate.Add(2,2);
            calculate.Substract(15, 36);
            calculate.Multiply(15, 36);
            calculate.divide(40,10);
        }
    }
}
