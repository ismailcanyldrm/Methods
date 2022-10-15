using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 5));
            Console.WriteLine(Add(8, 9));
            Console.ReadLine();



        }
        static int Add(int number1, int number2)
        {

            return number1 + number2;



        }
    }
}