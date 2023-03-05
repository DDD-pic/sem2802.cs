//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
Console.Write("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");

/*
Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
 x = (b2 - b1) / (k1 - k2) ;
 y = (k1 * (b2- b1)) / (k1 - k2) + b1;
if (k1 == k2)
{
 Console.WriteLine($"Точка не существует: ({x},{y}) ");
}

  Console.WriteLine($"Точка пересечения: ({x}; {y}) ");



