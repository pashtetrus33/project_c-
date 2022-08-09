Console.Clear();
int num = new Random().Next(10, 100);

Console.WriteLine(num);

int numPart1 = num / 10;
int numPart2 = num % 10;
int max = numPart2;
if (numPart1 > numPart2)
{
  max = numPart1;
}

 
Console.WriteLine(max);

