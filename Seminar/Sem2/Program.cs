// Методы-функции!!!
// int Pow (int n)
// {
//     return n * n;
// }

// void Pow2(int n)
// {
//     System.Console.WriteLine($"Quad of {n} -> {n * n}");
// }


// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// Pow2(a);

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// int DeletSecondDigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return ed + sot * 10;
//     }
//     else 
//     {
//         System.Console.WriteLine("You imput not three-digit number");
//         return 0;
//     }
// }




// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeletSecondDigit(a));

// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void DeletSecondDigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(ed + sot * 10);
//     }
//     else 
//     {
//         System.Console.WriteLine("You imput not three-digit number");
//     }
// }
// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// DeletSecondDigit(a);

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondToThirdPower(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         System.Console.WriteLine(Math.Pow(dec, ed));
//     }
//     else 
//     {
//         System.Console.WriteLine("You imput not three-digit number");
//     }
// }

// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// SecondToThirdPower(a);

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void FirstDivSecond(int a, int b)
// {
//     if(a % b == 0)
//     {
//         System.Console.WriteLine($"{a} кратно {b}");
//     }
//     else 
//     {
//         System.Console.WriteLine($"{a} не кратно {b}");
//     }
// }
// System.Console.WriteLine("Input number one: " );
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number two: " );
// int num2 = Convert.ToInt32(Console.ReadLine());
// FirstDivSecond(num1, num2);