// See https://aka.ms/new-console-template for more information
using Mirror_numbers;
using Prime_numbers;


Console.WriteLine("please add your first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please add your second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Mirror numbers between {firstNumber} and {secondNumber}:");
for (int i = firstNumber; i < secondNumber; i++)
{
    if (callculate_is_mirror.callculate(i))
    {
        Console.Write(i + "\t");
    }
}
Console.WriteLine("\n******************************************************************************");
callculate_prime_numbers prime = new callculate_prime_numbers();
callculate_prime_numbers.callculate(firstNumber, secondNumber);
