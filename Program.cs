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


//int age = 13;
//double height = 1.55;
//bool havParents = false;
//Console.Write("Родители рядом? 1 - да, 0 - нет");
//int vvod = int.Parse(Console.ReadLine());
//if (vvod == 1) { havParents = true; }
//if (age >= 14 && height >= 1.5)
//{
//    Console.WriteLine("Можно кататься");
//}
//else if (height >= 1.5 && havParents == true) { Console.WriteLine("Можно //кататься"); }
//else
//{
//    Console.WriteLine("Пока нельзя");
//}

//A

//int vod = int.Parse(Console.ReadLine());
//if (vod % 2 == 0) { Console.WriteLine("Чётное"); }
//else { Console.WriteLine("Нечётное"); }

//Б
//int input = int.Parse(Console.ReadLine());
//switch (input)
//{
//    case 2:
//        Console.WriteLine("2 - Неудовлетворительно");
//        break;
//    case 3:
//        Console.WriteLine("3 - удовлетворительно");
//        break;
//    case 4:
//        Console.WriteLine("4 - хорошо");
//        break;
//    case 5:
//        Console.WriteLine("5 - Отлично");
//        break;
//    default:
//        Console.WriteLine("Неверный день");
//        break;
//}

//Индивидуальный

//Console.Write("Введите свою фамилию: ");
//string surname = Console.ReadLine()!.Trim();
//
//if (string.IsNullOrEmpty(surname))
//{
//    Console.WriteLine("Фамилия не введена. Завершение работы.");
//    return;
//}
//
//Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
//
//var assigned = Enumerable.Range(1, 10)
//    .OrderBy(_ => rnd.Next())
//    .Take(2)
//    .OrderBy(x => x)
//    .ToList();
//
//Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//2 ВАР
//int vozrast = int.Parse(Console.ReadLine());
//if (vozrast >= 18) { Console.WriteLine("Доступ разрешён"); }
//else { Console.WriteLine("Доступ запрещён"); }

//6 ваp

int result = int.Parse(Console.ReadLine());
if (result > 100 || result < 0) { Console.WriteLine("Неверное значение"); }
else if (result <= 100 && result >= 90) { Console.WriteLine("Отлично"); }
else if (result <= 89 && result >= 75) { Console.WriteLine("Хорошо"); }
else if (result <= 74 && result >= 60) { Console.WriteLine("Отлично"); }
else { Console.WriteLine("Неудовлетворительно"); }

