// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumber(int[] array)
{
  int positive = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      positive += 1;
  }
  return positive;
}

Console.Clear();
Console.WriteLine("enter the numbers:");
int [] array = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ",array)}]");
Console.WriteLine(PositiveNumber(array));