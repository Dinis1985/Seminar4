// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int number = new Random().Next(100, 1000);

void MasRandom(int[] array)
{
    Random rmd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(0, 2);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

Console.WriteLine("Вывод массива:");
int[] mas = new int[8];
MasRandom(mas);
ShowArray(mas);
