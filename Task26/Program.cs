// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNum(int number);
{
    int i = 1;

    while (number % 10 != number)
    {
        number = number / 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToUInt32(Console.ReadLine());

int result = CountNum(num);
Console.WriteLine(result);


// Console.Write(" Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = num;
// int count = 0;
// if (x == 0)
//     {
//         count = 1;
//     }
// else
// {
// while (x != 0)
//     {
//         x = x / 10;
//         count++;
//     }
// }

// Вариант
// int Numbers(int number)
// {
// int x = number;
//  if (x == 0)
//     {
//         count = 1;
//     }
// else
// {
// while (x != 0)
//     {
//         x = x / 10;
//         count++;
//     }
// }  
// return count;
// }
// Console.WriteLine(Numbers(num));





// //Вариант 2
// // Console.WriteLine("Введите число: ");
// // int num = Convert.ToUInt32(Console.ReadLine());

// // int i = 1;

// // while (num % 10! = num)
// // {
// //     num = num / 10;
// //     i++;
// // }
// // Concole.WriteLine(i);
