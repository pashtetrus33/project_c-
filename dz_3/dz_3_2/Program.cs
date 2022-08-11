/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
bool repeat = true;
int[] pointA = new int[3];
int[] pointB = new int[3];

void  distanceCount(int[] point1, int[] point2)
{   
 double distance = Math.Sqrt(Math.Pow((point2[0] - point1[0]),2) +  Math.Pow((point2[1] - point1[1]),2) +  Math.Pow((point2[2] - point1[2]),2));
 distance = Math.Round(distance,2);
 Console.WriteLine($"Расстояние между двумя точками равно {distance}");
}

while (repeat)
{
Console.WriteLine("Введите коориданты первой точки А: ");
Console.Write("Введите x: ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
pointA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
pointA[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коориданты первой точки B: ");
Console.Write("Введите x: ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
pointB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
pointB[2] = Convert.ToInt32(Console.ReadLine());
 
distanceCount(pointA, pointB);  // Вычисляем и выводим расстояние между двумя точками
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}