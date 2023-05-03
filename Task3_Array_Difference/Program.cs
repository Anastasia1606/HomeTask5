double[] array = { 10.3, 12.8, 1.5, 0.8, 1.6 };

double min = array[0];
double max = array [0];
foreach (double number in array)
{
  if (number < min)
  {
    min = number;
  }
  if (number > max)
  {
    max = number;
  }
}

double diff = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");