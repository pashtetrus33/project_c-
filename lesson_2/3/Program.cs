Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Наше рандомное число равно {num} ");

int numPart1 = num / 100;
int numPart2 = num % 10;


//Console.WriteLine($"Наше рандомное число без второй цифры {numPart1} ");
//Console.WriteLine($"Наше рандомное число без второй цифры {numPart2} ");
Console.WriteLine($"Наше рандомное число без второй цифры {numPart1}{numPart2} ");




