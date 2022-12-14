/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


// метод вывода cуммы  натуральных чисел от М до N
int SumNaturalNum(int[] arrayNatural)
{
    int sum = 0;
    for (int i = 0; i < arrayNatural.Length; i++)
        sum += arrayNatural[i];
    return sum;
}

// метод вывода натуральных чисел от М до N
int[] NaturalNum(int m, int n)
{
    int index = 0;
    int[] array = new int[n - m + 1];
    for (int i = m; i <= n; i++)
        array[index++] = i;
    return array;
}

//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа выведет все натуральные числа в промежутке от M до N.");
    int m = 0;
    //проверка на ввод целого числа больше нуля
    while (m <= 0)
    {
        Console.Write("Введите M (> 0): ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out m))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }
    Console.WriteLine($"М = {m}");
    int n = 0;
    //проверка на ввод целого числа больше нуля
    while ((n <= 0) || (n < m))
    {
        Console.Write("Введите N (> 0) N должно быть больше М: ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out n))
            Console.Write("Ошибка ввода! Введите целое число больше нуля!: ");
    }

    Console.WriteLine($"М = {m}");
    Console.WriteLine($"N = {n}");
    int[] array = NaturalNum(m, n);
    Console.WriteLine($"Натуральные числа от {m} до {n}: {String.Join(" ", array)}");
    Console.WriteLine($"Cумма натуральных чисел от {m} до {n}: {SumNaturalNum(array)}");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
