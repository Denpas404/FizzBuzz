using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClassLibrary;

namespace FizzBuzzConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzLogic logic = new FizzBuzzLogic();

            List<int> list = new List<int>() { 3, 5, 15, 98, 10, 4};

            foreach (var item in list)
            {
                Console.WriteLine(logic.FizzBuzz(item));
            }
            Console.ReadKey();
        }
    }
}
