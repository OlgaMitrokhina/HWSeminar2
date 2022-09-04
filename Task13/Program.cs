// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(n);

if (n > 99)
{
Console.WriteLine("Третья цифра цифра этого числа -> "+stringNumber[2]);
}
else
{
Console.WriteLine($"Третьей цифры в числе {n} нет");
}