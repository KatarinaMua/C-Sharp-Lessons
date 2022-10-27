/*

// Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. 

int a = 0;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
int b = 0;
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
int c = 1;

for (int i = 1; i < (b + 1); i++)
    c = c * a;

Console.Write($"{a} в степени {b} равно {c}");

*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System.ComponentModel.DataAnnotations;

int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
int b = 0;

while (a > 0)
{
    b = b + a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в числе {a} равна {b}");
*/


/*
//Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array;

array = FillArr();
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

int[] FillArr()
{
    int[] _array = new int[8];
    for (int i = 0; i < 8; i++)
        _array[i] = new Random().Next();
    return _array;
}
*/