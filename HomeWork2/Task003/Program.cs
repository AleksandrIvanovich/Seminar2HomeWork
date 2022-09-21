// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от одного до семи:");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num > 7)
{
    Console.WriteLine("Вы ввели некоректное число!");
}
if (num > 5)
{
    Console.WriteLine("Да!");
}
if (num < 5)
{
    Console.WriteLine("Нет!");
}