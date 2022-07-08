/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Max = " + num1);
}

if (num1 < num2)
{
    Console.Write("Max = " + num2);
}
*/


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int num1, num2, num3;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Max = " + num1);
}

if (num1 < num2)
{
    Console.Write("Max = " + num2);
}

if (num1 > num3)
{
    Console.Write("Max = " + num1);
}

if (num1 < num3)
{
    Console.Write("Max = " + num3);
}




