using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("How old are you?");

            String age = Console.ReadLine();
            Console.WriteLine(name + " is " + age + " years old");
            
            Console.ReadLine();
        }
    }
}
