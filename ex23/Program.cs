// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);

int[] numbers = new int[N];

for (int i = 0; i < N; i++)
{
    numbers[i] = (i + 1) * (i + 1) * (i + 1);

    Console.WriteLine($"{i + 1} {numbers[i]}");
}