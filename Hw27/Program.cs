// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int count = Convert.ToString(num).Length;
    int step = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        step = number - number % 10;
        sum = sum + (number - step);
        number = number / 10;
    }
    return sum;
}

int result = SumNumbers(num);
Console.WriteLine($"Сумма цифр в числе {num} -> {result}");

