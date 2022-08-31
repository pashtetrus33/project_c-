/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 5, 6, 7, 8"" */

// метод вывода натуральных чисел от М до N
int[] naturalNum(int m, int n)
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
    Console.WriteLine($"Натуральные числа от {m} до {n}: {String.Join(" ",naturalNum(m, n))}");

    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}
