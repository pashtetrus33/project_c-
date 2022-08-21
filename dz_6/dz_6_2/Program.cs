/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5) */

bool repeat = true;
while (repeat)
{
    Console.Clear();
    Console.WriteLine("************* Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ****************");
    Console.WriteLine();

    Console.WriteLine("Введите коэффициенты для первой прямой:");
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите коэффициенты для второй прямой:");
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    // Проверка на параллельность прямых
    if ((k1 == k2) && (b1 != b2))
    {
        Console.WriteLine("Прямые - параллельные!");
        Console.WriteLine();
        Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
        if (Console.ReadLine()?.ToLower() == "q")
            break;
        else
            continue;
    }
    // Проверка на то, что прямые идентичны
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Вы ввели одну и ту же прямую!");
        Console.WriteLine();
        Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
        if (Console.ReadLine()?.ToLower() == "q")
            break;
        else
            continue;
    }

    // k1x + b1 = k2x + b2   x(k1 - k2) = b2 - b1   x = (b2-b1)/(k1 - k2)
    // y = k1*x + b1 или y = k2*x + b2
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    // Исправление ответа -0 если числитель 0, а знаменатель < 0 
    if (x == -0)
        x = 0;

    Console.WriteLine($"Координаты точки пересечения равны x: {Math.Round(x, 3)}  y: {Math.Round(y, 3)}");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
