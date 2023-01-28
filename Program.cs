// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа по очереди: ");

int number1=Convert.ToInt32(Console.ReadLine());
int number2=Convert.ToInt32(Console.ReadLine());


if (number1>number2)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(number1);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number2);
}

else if (number1==number2)
{
    Console.WriteLine("Числа равны");
}

else 
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(number2);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number1);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Перейдем к задаче 4");

Console.WriteLine("Введите три числа по очереди: ");

int numberA1=Convert.ToInt32(Console.ReadLine());
int numberA2=Convert.ToInt32(Console.ReadLine());
int numberA3=Convert.ToInt32(Console.ReadLine());
int max=numberA1;

if (numberA1>numberA2) 
{
    max=numberA1;
}
else 
{
    max=numberA2; 
}

if (max>numberA3) 
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(max);
}

else 
{
    max=numberA3;
    Console.Write("Максимальное число: ");
    Console.WriteLine(max);
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Перейдем к задаче 6");

Console.WriteLine("Введите число:");

int number=Convert.ToInt32(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine($"Число {number} чётное");  
}
else
{
    Console.WriteLine($"Число {number} нечётное");  
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Перейдем к задаче 8");

Console.WriteLine("Введите число:");

int numberN=Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= numberN; i = i + 2)
{
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();