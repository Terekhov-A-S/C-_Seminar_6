// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите число, которое будет обозначать количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrNumbers = new int[m];
void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Compare(int[] arrNumbers)
{
  int count = 0;
  for (int i = 0; i < arrNumbers.Length; i++)
  {
    if(arrNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {Compare(arrNumbers)} ");

