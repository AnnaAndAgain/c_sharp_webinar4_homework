/*
DONE
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/ 

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountDigits(int number)
{
    number = Math.Abs(number);
    int count = 0;
    int i = 10;
    while (number > 0)
    {
        number = number - number%i;
        count = count + 1;
        i=i*10;
    }
    return count;
}

int[] NumberByDigits(int number, int numOfDigits)
{
    number = Math.Abs(number);
    int[] tmpArray = new int[numOfDigits];
    for (int i = 0; i < numOfDigits; i++)
    {
        tmpArray[i] = number%10;
        number/=10;
    }
    return tmpArray;
}

int SumArray(int[] tmpArray)
{
    int tmpSum = 0;
    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpSum = tmpSum + tmpArray[i];
    }
    return tmpSum;
}

int N = ReadInt("Введите число:");
int[] digits = NumberByDigits(N, CountDigits(N));
//Console.WriteLine(string.Join(",", digits));
Console.WriteLine(SumArray(digits));