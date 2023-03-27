// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 ->  (-0,5; -0,5)

void IntersectionLine(double[] array)
{
  double[] coord = new double[2];
  coord[0] = Math.Round((array[2] - array[0]) / (array[1] - array[3]), 2);
  coord[1] = Math.Round(array[1] * coord[0] + array[0], 2);
  Console.WriteLine($"[{string.Join(", ",coord)}]");
}
Console.Clear();
Console.WriteLine("enter the coefficient b1, k1, b2, k2:");
double[] array = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.Write("coordinates: ");
IntersectionLine(array);