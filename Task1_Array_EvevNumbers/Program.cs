int Prompt (string message)
{
  System.Console.Write(message);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}

int Length = Prompt("Длина массива: ");
int[] array = new int[Length];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
  array[i] = random.Next(100, 1000);
}

void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.WriteLine("]");
}

int evenCount = 0;
foreach (int number in array)
{
  if (number % 2 == 0)
  {
    evenCount++;
  }
}

PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");