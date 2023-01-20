// d = √ (х А – х В) 2 + (у А – у В) 2
// Math.Sqrt(); //находит квадратный корень числа
// Math.Pow(a,2); //возводит число в степерь
//Math.Round(); //округляет число

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09 
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.Write("Введите координату x1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1=int.Parse(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2=int.Parse(Console.ReadLine());

// double result;

double result=Math.Sqrt((Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)));  // d = √ (х А – х В) 2 + (у А – у В) 2
// result=Math.Round(result,3);                                         // или так округление
Console.WriteLine($"Расстояние между заданными точками {result:F3}");   //или округление через {result:F3}, где F3-количество цифр после запятой
                                                      //result
                                                      //Math.Round(result,3)