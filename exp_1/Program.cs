// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Clear();

Console.Write("Введите координату X: ");
int X=int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y=int.Parse(Console.ReadLine());

// // Вариант 1
// if (X>0&&Y>0)    Console.WriteLine("Точка в первой четверти");
// if (X<0&&Y>0)    Console.WriteLine("Точка во второй четверти");
// if (X<0&&Y<0)    Console.WriteLine("Точка в третьей четверти");
// if (X>0&&Y<0)    Console.WriteLine("Точка в четвертой четверти");

//Вариант 2
if (Y>0)
{
    if (X>0) Console.WriteLine("Точка в первой четверти");
    else Console.WriteLine("Точка во второй четверти");
}
else
{
    if (X<0) Console.WriteLine("Точка в третьей четверти");
    else Console.WriteLine("Точка в четвертой четверти");
}