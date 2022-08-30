// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

double[,] ratio = new double[2, 2];
double[] intersectionPoint = new double[2];
void InputRatio()
{
  for (int i = 0; i < ratio.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-ой прямой\n");
    for (int j = 0; j < ratio.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      ratio[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] Decision(double[,] ratio)
{
  intersectionPoint[0] = (ratio[1,1] - ratio[0,1]) / (ratio[0,0] - ratio[1,0]);
  intersectionPoint[1] = intersectionPoint[0] * ratio[0,0] + ratio[0,1];
  return intersectionPoint;
}
void OutputResponse(double[,] ratio)
{
  if (ratio[0,0] == ratio[1,0] && ratio[0,1] == ratio[1,1]) 
  {
    Console.Write($"* Прямые совпадают *\n");
  }
  else if (ratio[0,0] == ratio[1,0] && ratio[0,1] != ratio[1,1]) 
  {
    Console.Write($"* Прямые параллельны *\n");
  }
  else 
  {
    Decision(ratio);
    Console.Write($"* Точка пересечения прямых: ({intersectionPoint[0]}, {intersectionPoint[1]}) *\n");
  }
}
InputRatio();
OutputResponse(ratio);

