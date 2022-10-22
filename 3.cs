/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? a = Console.ReadLine();
void CheckCount(string a)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine($"Число {a} - палиндром.");
    }
    else Console.WriteLine($"Число {a} - не палиндром.");
}
if (a.Length == 5)
{
    CheckCount(a);
}
else Console.WriteLine($"Введите число из пяти цифр");
*/



/*
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int[3];
int[] B = new int[3];
Console.Write($"Введите координату X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату Z первой точки: ");
int.TryParse(Console.ReadLine()!, out A[2]);
Console.Write($"Введите координату X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату Z второй точки: ");
int.TryParse(Console.ReadLine()!, out B[2]);
int x = (A[0] - B[0]) * (A[0] - B[0]);
int y = (A[1] - B[1]) * (A[1] - B[1]);
int z = (A[2] - B[2]) * (A[2] - B[2]);
double c = Math.Sqrt(x + y + z);
c = Math.Round(c, 5);
Console.Write($"Длина отрезка {c} пунктов");
*/



/*
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int i = 1; i <= a; i++)
    Console.Write($"{i * i * i} ");
*/