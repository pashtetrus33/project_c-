Console.Clear();
Console.Write("Введите номер четверти: ");
int quaterNumber = Convert.ToInt32(Console.ReadLine());

if ((quaterNumber < 1) || (quaterNumber > 4))
{
    Console.WriteLine("Ввели неправильный номер четверти (от 1 до 4) ");

}

else if (quaterNumber == 1)
{
Console.WriteLine("Диапазон  0 < x < + inf, 0 < y < + inf");
}

else if (quaterNumber == 2)
{
Console.WriteLine("Диапазон - inf < x < 0, 0 < y < + inf");
}

else if (quaterNumber == 3)
{
Console.WriteLine("Диапазон - inf < x < 0, - inf < y < 0");
}
else
{
Console.WriteLine("Диапазон 0 < x < + inf, - inf < y < 0");
}
