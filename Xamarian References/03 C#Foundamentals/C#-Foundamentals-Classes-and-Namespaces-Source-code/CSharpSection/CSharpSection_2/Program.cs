using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSection_2.Classes;

namespace CSharpSection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMath.Division(432.23f, 54523.2f));

            

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Substract(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiplication(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Division(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}
