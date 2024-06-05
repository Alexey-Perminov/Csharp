// Console.WriteLine("Input number: ");

// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("quad of " + x + "is" + x * x);

// Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x == y * y)
// {
//     Console.WriteLine($"x = {x}, y = {y} -> yes");
// }
// else
// {
//     Console.WriteLine($"x = {x}, y = {y} -> no");
// }

// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while(start <= n)
// {
//     System.Console.Write(start + " ");
//     start ++;
// }

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num <= 999)
{
    int ed = num % 10;
    int sot = num / 100;
    System.Console.WriteLine("sum = " + (ed + sot));
}
else
{
    System.Console.WriteLine("You input not three-digit number");
}