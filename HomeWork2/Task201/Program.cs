// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число:");
int num = int.Parse(Console.ReadLine());
int a = num % 100;
int b = num % 10;
int result = (a - b) / 10;

if (num < 100 || num >1000)
{
    Console.WriteLine("Введено некорректное число!");
}
else
{
    Console.WriteLine(result);
}

