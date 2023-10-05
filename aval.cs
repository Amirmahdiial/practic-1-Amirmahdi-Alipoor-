using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_1_Amirmahdi_Alipoor_
{
    public class aval
    {
        public static void calculation(int firstNumber,int secondNumber)
        {
            bool ckeek = true;
            for (int i = firstNumber; i < secondNumber; i++)
            {
                for (int j = 2; j < secondNumber; i++)
                {
                    if (i!=j & i % j ==0)
                    {
                        ckeek = false;
                        break;
                    }
                    
                }
                if (ckeek)
                {
                    Console.Write("Prime numbers is:/t"+i);
                }
                ckeek=true; 
            }
            Console.ReadKey(); 
        }
    }
}
