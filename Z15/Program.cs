//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели:");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1<=5)
{
    Console.Write("Это не выходной");
}
 else 
 {
     Console.Write("Это выходной");
 }
