using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffBetweenXand13
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput <= 13)
            {
                Console.WriteLine(13 - userInput);
            }
            else
            {
                Console.WriteLine(2 * Math.Abs(13 - userInput));
            }
            Console.ReadLine();
        }
    }
}
