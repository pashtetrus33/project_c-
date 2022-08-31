/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/


int AcermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AcermanFunction(m - 1, 1);
    else
        return AcermanFunction(m - 1, AcermanFunction(m, n - 1));
}


//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n..");
    int m = -1;
    //проверка на ввод целого числа больше нуля
    while (m < 0)
    {
        Console.Write("Введите M (>= 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out m))
            Console.Write("Ошибка ввода! Введите целое неотрицательное число!: ");
    }
    Console.WriteLine($"М = {m}");
    int n = -1;
    //проверка на ввод целого числа больше нуля
    while (n < 0)
    {
        Console.Write("Введите N (>= 0) N должно быть больше или равно М: ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out n))
            Console.Write("Ошибка ввода! Введите целое неотрицательное число!: ");
    }

    Console.WriteLine($"М = {m}");
    Console.WriteLine($"N = {n}");
    Console.WriteLine($"Функция Аккремана равна {AcermanFunction(m, n)}");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}


