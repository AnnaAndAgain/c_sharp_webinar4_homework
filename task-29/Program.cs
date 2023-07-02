/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
НО! В примерах вообще не 8 чисел в масиве, а 5 и потом ешще 3...

! Заполняем случайными числами
!! Диапазон должен регулироваться пользователем.
!! Размер массива тоже запрашивать у пользователя.
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArrayRandom(int tmpLength, int tmpMin, int tmpMax)
{
    int[] tmpArray = new int[tmpLength];
    Random randnum = new Random();

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = randnum.Next(tmpMin, tmpMax+1);
    };

    return tmpArray;
}

void PrintArray(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

int len = ReadInt("Введите размер массива:");
int min = ReadInt("Введите минимальное значение (не меньше -255):");
int max = ReadInt("Введите максимальное значение (не больше 255):");
int[] array = FillArrayRandom(len, min, max);
PrintArray(array);