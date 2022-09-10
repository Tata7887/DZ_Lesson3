//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
//23432 -> да
//12821 -> да


Console.WriteLine("Введите число");
string numbers = Console.ReadLine()!;
int[] num = new int[5];

if ((numbers[0] == numbers[4]) && (numbers[1] == numbers[3]))
    Console.WriteLine($"Число является палиндромом");

else

    Console.WriteLine($"Число не является палиндромом");