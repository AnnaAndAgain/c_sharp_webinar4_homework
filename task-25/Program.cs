/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число:");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень (натуральное число):");
int B = Convert.ToInt32(Console.ReadLine());

if (B>0) 
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    System.Console.WriteLine(result);
}
else System.Console.WriteLine("Введите целую положительную степень!");