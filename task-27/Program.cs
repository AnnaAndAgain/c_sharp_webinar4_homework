/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/ 


/// тут ваще мимо

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] NumberByDigits(int number) 
{
    string tmpString = Convert.ToString(number);
    //System.Console.WriteLine(tmpString);

    int[] tmpArray = new int[tmpString.Length];
    System.Console.WriteLine(string.Join(",", tmpArray));

    for (int i=0; i < tmpString.Length; i++)
    {
        char X = int.Parse(tmpString[i]);
        //tmpArray[i] = ;
        System.Console.WriteLine(X);
        //System.Console.WriteLine(string.Join(",", tmpArray));
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
int[] digits = NumberByDigits(N);
System.Console.WriteLine(string.Join(",", digits));
Console.WriteLine(SumArray(digits));