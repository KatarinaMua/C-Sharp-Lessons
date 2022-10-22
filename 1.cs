/* 
Console.WriteLine("Введи 2 числа");
int a, b;
string userIntera, userInterb;
Console.Write(value: "Введи первое число - ");
userIntera = Console.ReadLine()!;
int.TryParse(userIntera, out a);
Console.Write(value: "Введи второе число - ");
userInterb = Console.ReadLine()!;
int.TryParse(userInterb, out b);
if (a > b)
{
    Console.WriteLine(value: $"Число {a} больше чем {b}");
}
else if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
    Console.WriteLine(value: $"Число {b} больше чем {a}");
} 
*/

/*
Console.WriteLine("Введи 3 числа");
int a, b, c;
string userIntera, userInterb, userInterc;
Console.Write(value: "Введи первое число - ");
userIntera = Console.ReadLine()!;
int.TryParse(userIntera, out a);

Console.Write(value: "Введи второе число - ");
userInterb = Console.ReadLine()!;
int.TryParse(userInterb, out b);

Console.Write(value: "Введи третье число - ");
userInterc = Console.ReadLine()!;
int.TryParse(userInterc, out c);

if (a > b && a > c)
{
    Console.WriteLine(value: $"Число {a} самое большое");
}
else if (b > c)
{
    Console.WriteLine($"Числа {b} самое большое");
}
else
{
    Console.WriteLine(value: $"Число {c} самое большое");
}
*/

/*
int a;
string userIntera;
Console.Write(value: "Введи число - ");
userIntera = Console.ReadLine()!;
int.TryParse(userIntera, out a);

if (a % 2 == 0) 
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}
*/

/*
int a;
string userIntera;
Console.Write(value: "Введи число - ");
userIntera = Console.ReadLine()!;
int.TryParse(userIntera, out a);
Console.Write($"Четные числа промежутка от 1 до {a}: ");
for (int i = 1; i <= a; i++)
{
if (i % 2 == 0) 
{
    Console.Write(i + " ");
}
}
*/