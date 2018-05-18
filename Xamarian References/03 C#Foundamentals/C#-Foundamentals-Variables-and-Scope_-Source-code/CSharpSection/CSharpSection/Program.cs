using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Add(432, 543);

            Console.ReadLine();
        }

        private static void Add(int n1, int n2)
        {
            int result;
            result = n1 + n2;

            Console.WriteLine(result);
        }
    }
}
