// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите переменные b1, k1, b2, k2 через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double pointX;
double pointY;
int a = array[1];
int b = array[3];
int c = array[0];
int d = array[2];

if (a == b)
{
    Console.WriteLine("Прямые не пересикаются");
}
else
{
    pointX = (double)(d - c) / (a - b);
    pointY = (double)a * (d - c) / (a - b) + c;
    Console.WriteLine($"Точки пересичения - Координаты: Х: {pointX} | Y: {pointY} ");
  
}
