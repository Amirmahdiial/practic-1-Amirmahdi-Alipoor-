using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    public class callculate_prime_numbers
    {
        public static void callculate(int firstNumber, int secondNumber)
        {
            bool cheek = true;
            Console.WriteLine($"Prime Numbers between {firstNumber} and {secondNumber}: ");
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = 2; j <= secondNumber; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        cheek = false;
                        break;
                    }

                }
                if (cheek)
                {
                    Console.Write("\t" + i);
                }
                cheek = true;
            }
            Console.ReadKey();
        }
    }
}
