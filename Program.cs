using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWrld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there");
            //Asks user age.
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            //Gives user a place to input age
            Console.WriteLine($"You are {input} years old!");
            Console.WriteLine("General Kenobi");
        }
    }
}
