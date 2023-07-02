/*
DONE
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void NatulnayaStepen(int baseOfPower, int exponentOfPower)
{
    if (exponentOfPower>0) 
    {
        double result = 1;
        for (int i = 1; i <= exponentOfPower; i++)
        {
            result = result * baseOfPower;
        }
        System.Console.WriteLine(result);
    }
    else System.Console.WriteLine("Введите целую положительную степень!");
}

int A = ReadInt("Введите число:");
int B = ReadInt("Введите степень (натуральное число):");
NatulnayaStepen(A, B);