// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число и программа покажет вторую цифру этого числа: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(n);

if(n < 1000 && n > 99)
{
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
}
else
{
Console.WriteLine ("Число не трехзначное!");
}