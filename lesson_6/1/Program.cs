/*Задача Перевода числа из десятичной в двоичную систему счисления*/

// Метод подсчета разрядности числа в двоичной системе счисления
int LengthNumberCount(int number)
{
    int numberLength = 0;
    while (number > 0)
    {
        number /= 2;
        numberLength++;
    }
    return numberLength;
}
// метод перевода чилса из десятичной в двоичную систему счисления
int[] DecimalToBinary(int number, int length)
{
    int[] result = new int[length];
    int i = 0;
    while (number > 0)
    {
        result[length - i - 1] = number % 2;
        number /= 2;
        i++;
    }
    return result;
}

//флаг для выхода из основного цикла программы
bool repeat = true;

// основной цикл программы
while (repeat)
{
    Console.Clear();
    Console.WriteLine("Программа переводит число, введенное пользователем из десятичной в двоичную систему счисления.");
    int numDecimal = -1;
    //проверка на ввод целого числа больше нуля
    while (numDecimal < 0)
    {
        Console.Write("Введите целое неотрицательное число: ");
        //проверка на ввод целого числа
        while (!int.TryParse(Console.ReadLine(), out numDecimal))
            Console.Write("Ошибка ввода! Введите целое, неотрицательное число: ");
    }
    int length = LengthNumberCount(numDecimal);
    int[] result = DecimalToBinary(numDecimal, length);
    Console.WriteLine($"Число разрядов числа в двоичной системе равно: {LengthNumberCount(numDecimal)}");
    Console.WriteLine($"Число {numDecimal} в двоичной системе счисления равно {string.Join(" ", result)}");
    Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'Q' затем 'ENTER'");
    string? decision = Console.ReadLine();
    if ((decision?.ToLower() == "q") || (decision?.ToLower() == "й"))
        repeat = false;
}

