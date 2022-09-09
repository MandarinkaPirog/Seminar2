//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая цифра числа:");
int a = num1/10 % 10;
Console.Write(Math.Abs(a));