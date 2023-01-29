// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math

int Degree(int A, int B)
{
    int count = 1;
    int result = A;
    for (result = A; count < B; count++)
    {
        result = result * A;
    }
    return result; 
}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int result = Degree(A, B);
Console.WriteLine(result);



