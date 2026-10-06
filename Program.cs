//int age = 15;
//if (age >= 18) { Console.WriteLine("Доступ разрешен"); }
//Console.WriteLine("Программа продолжает работу");

using System.Runtime.InteropServices;

int age = 15;
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
    int number = 18 - age;
    Console.WriteLine($"До совершеннолетия осталось {number} лет")
}