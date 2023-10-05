// See https://aka.ms/new-console-template for more information

using Mirror_numbers;
using Prime_numbers;

Console.WriteLine("please enter start number:");
int startNumber=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("please enter end number");
int endNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Mirror numbers between {startNumber} and {endNumber}:");
for (int i = startNumber; i < endNumber; i++)
{
	if (callculate_is_mirror.callculate(i))
	{
		Console.Write(i+"\t");
	}
}

