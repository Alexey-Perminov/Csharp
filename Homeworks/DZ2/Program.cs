// Задача 1!

// System.Console.WriteLine("imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 7 == 0 && num % 23 == 0)
// {
//     System.Console.WriteLine("The number is a multiple of 7 and 23");
// }
// else
// {
//     System.Console.WriteLine("The number is not multiple of 7 and 23");
// }

// Задача 2!

// System.Console.WriteLine("Введите координаты точки x, y через пробел: ");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x == 0)
//     System.Console.WriteLine("Точка находится на оси координат Y.");
// if (y == 0)
//     System.Console.WriteLine("Точка находится на оси координат X.");
// else
// {
//     if (x > 0 && y > 0)
//         System.Console.WriteLine("Точка находится в I четверти плоскости.");
//     if (x > 0 && y < 0)
//         System.Console.WriteLine("Точка находится в II четверти плоскости.");
//     if (x < 0 && y < 0)
//         System.Console.WriteLine("Точка находится в III четверти плоскости.");
//     if (x < 0 && y > 0)
//         System.Console.WriteLine("Точка находится в IV четверти плоскости.");
// }

// Задача 3! 

// System.Console.WriteLine("Введите число из отрезка [10 - 99]");
// int num = Convert.ToInt32(Console.ReadLine());
// int FirstDigit = num / 10;
// int SecondDigit = num % 10;
// int maxDigit = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
//  Console.WriteLine(maxDigit);

// Задача 4!

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}