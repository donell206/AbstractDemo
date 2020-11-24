using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public abstract class Calculate
    {

        public void Substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        public void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }


        public abstract void Add(int a, int b);
        public abstract void divide(int a, int b);

    }
}
