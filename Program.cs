//int age = 15;
//if (age >= 18) { Console.WriteLine("Доступ разрешен"); }
//Console.WriteLine("Программа продолжает работу");

//using System.Runtime.InteropServices;
//
//int age = 15;
//if (age >= 18)
//{
//    Console.WriteLine("Доступ разрешён");
//}
//else
//{
//    Console.WriteLine("Доступ запрещён");
//    int number = 18 - age;
//    Console.WriteLine($"До совершеннолетия осталось {number} лет");
//}

//int age = 74;
//if (age < 13) { Console.WriteLine("Ребенок"); }
//else if (age < 18) { Console.WriteLine("Подросток"); }
//else if (age >= 18 && age <= 60) { Console.WriteLine("Взрослый"); }
//else Console.WriteLine("Пенсионер");


int age = 13;
double height = 1.55;
bool havParents = false;
Console.Write("Родители рядом? 1 - да, 0 - нет");
int vvod = int.Parse(Console.ReadLine());
if (vvod == 1) { havParents = true; }
if (age >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
}
else if (height >= 1.5 && havParents == true) { Console.WriteLine("Можно кататься"); }
else
{
    Console.WriteLine("Пока нельзя");
}
