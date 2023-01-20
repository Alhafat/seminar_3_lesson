// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Clear();
Console.Write("Введите любое число: ");
int number=int.Parse(Console.ReadLine()!);

int count=1;

// К варианту 3
Console.Write($"{Math.Pow(count,2)}"); 
count++;

while (count<=number)
{
    // //Вариант 1
    // double result=Math.Pow(count++,2);       
    // Console.Write($", {result}");

    // //Вариант 2
    // Console.Write($"{Math.Pow(count,2)}");
    // if (count!=number)  Console.Write(", "); //выводит запятую после каждой цифры 
    // count++;

    //Вариант 3(+то что выше)
    Console.Write($", {Math.Pow(count++,2)}"); 
}