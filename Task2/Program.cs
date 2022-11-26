/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите второе число: ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);

Console.WriteLine("Введите третье число: ");
string number3Str = Console.ReadLine();
int number3 = Convert.ToInt32(number3Str);

if(number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine($"Максимальное чилсо {number1}");
    }

    else 
    {
    Console.WriteLine($"Максимальное чилсо {number3}");
    }
}

else if(number2 > number3)
{
    Console.WriteLine($"Максимальное чилсо {number2}");
}
else
{
    Console.WriteLine($"Максимальное чилсо {number3}");
}
