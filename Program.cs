// See https://aka.ms/new-console-template for more information

using practic_1_Amirmahdi_Alipoor_;
bool ckeek = true;
Console.WriteLine("select first number");
int firstNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("select second number");
int secondNumber = Convert.ToInt16(Console.ReadLine());
//aval aval=new aval();
//aval.calculation(firstNumber, secondNumber);

for (int i = firstNumber; i < secondNumber; i++)
{
    for (int j = 2; j < secondNumber; i++)
    {
        if (i != j & i % j == 0)
        {
            ckeek = false;
            break;
        }

    }
    if (ckeek)
    {
        Console.Write("Prime numbers is:/t" + i);
    }
    ckeek = true;
}
Console.ReadKey();
