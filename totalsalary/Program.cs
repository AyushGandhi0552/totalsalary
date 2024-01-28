using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalsalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter basic salary:");
            int bs = Convert.ToInt32(Console.ReadLine());

            int da = bs * 10 / 100;
            int hra = bs * 10 / 100;    


            Console.WriteLine(firstName,lastName);
            Console.ReadKey();
        }
    }
}
