// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти: ");
int number=int.Parse(Console.ReadLine()!);

// ВАриант 1
if (number==1) Console.WriteLine("Координаты X>0 и Y>0");
else if (number==2) Console.WriteLine("Координаты X<0 и Y>0");
else if (number==3) Console.WriteLine("Координаты X<0 и Y<0");
else if (number==4) Console.WriteLine("Координаты X>0 и Y<0");

// ВАриант 2
// if (coordinata > 2)
// {
//     System.Console.WriteLine("Координата Y < 0");
// }
// else
// {
//     System.Console.WriteLine("Координата Y > 0");
// }

// if (coordinata == 1 || coordinata == 4)
// {
//     System.Console.WriteLine("Координата X > 0");
// }
// else
// {
//     System.Console.WriteLine("Координата X < 0");
// }

// //Вариант 3
// switch(number)
// {
//     case 1:
//     {
//         Console.WriteLine("Координаты X>0 и Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("Координаты X<0 и Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("Координаты X<0 и Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("Координаты X>0 и Y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неверная четверть");
//         break;
//     }
// }