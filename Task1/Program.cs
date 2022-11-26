/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите второе число: ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);


if(number1 > number2) 
{
    Console.WriteLine($"Максимальное чилсо {number1}, Минимальное число {number2}");
}
else if(number2 > number1)
{
    Console.WriteLine($"Максимальное чилсо {number2}, Минимальное число {number1}");
}

