using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What is Your Name?");
            var fname = Console.ReadLine();
            Console.WriteLine("What is Your Last Name?");
            var lname = Console.ReadLine();

            string fullname = fname + " " + lname;

            Console.WriteLine("Please Enter A Number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter A Second Number:");
            double num2 = double.Parse(Console.ReadLine());

            double result;



            Console.WriteLine("Please Select Which Equation To Use: \n1. Addition \n2. Subraction \n3. Multiplication \n4. Division");
            int des = int.Parse(Console.ReadLine());

            if (des == 1)
            {
                result = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            }
            else if (des == 2)
            {
                result = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
            }
            else if (des == 3)
            {
                result = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            }
            else if (des == 4)
            {
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            else while (des >4)
            {
                    Console.WriteLine("ERROR. INVALID INPUT.");
                    Console.ReadLine();
                    
                }
            Console.WriteLine("\nThank You For Your Assistance {0}", fullname);
            Console.ReadLine();
           
            

        }
    }
}
