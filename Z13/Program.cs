//Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

Console.Write("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num1);
if (num2.Length > 2)
{
    Console.Write("Третья цифра:"+ num2[2]);
}

else
{
    Console.Write("Третьей цифры нет");
}